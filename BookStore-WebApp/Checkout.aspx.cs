using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Checkout : System.Web.UI.Page
{
    public static string yourPassword = "Meant123";
    protected void Page_Load(object sender, EventArgs e)
    {
        
        GetSession();
            if(IsPostBack == false)
        {
            calOrderTotal();
        }
    }
    
    private void GetSession()
    {
        double totalCost = 0.0;
        double weight = 0.0;
        int quantity = 0;
        List<Book> shoppingCart = (List<Book>)Session["shoppingCart"];

        if(shoppingCart.Count < 1)
        {
            this.submitButton.Enabled = false;
            this.SummaryLabel.Text = "Your Shopping Cart is Empty:";
        }
        else
        {
            totalCost = (double)Session["TotalCost"];
            this.OrderTotalLabel.Text += "$" + totalCost.ToString();

            weight = (double)Session["TotalWeight"];
            this.WeightLabel.Text += weight.ToString();

            quantity = (int)Session["QuantityTotal"];
            this.QuantityLabel.Text += quantity.ToString();

        }

    }

    protected void calOrderTotal()
    {
       
        double ship = 0.0;
        double dWork = 0.0;
        double totalCost = (double)Session["TotalCost"]; ;

        dWork = (double)Session["TotalWeight"];
        ship = (int)dWork * .46 + 1.0;
        ShippingCostLabel.Text += "$" + ship.ToString();
        ItemTotalCostLabel.Text += "$" + totalCost.ToString();
        dWork = (double)Session["TotalCost"];
        dWork = dWork + ship;
        TotalLabel.Text += "$" + dWork.ToString();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Server.Transfer("Default.aspx?");
    }

    protected void submitButton_Click(object sender, EventArgs e)
    {
        string sWork = "CSCD379 - ASP.Net Programming with C# \n\n";
        sWork += "Your order has been processed.\n\n";
        sWork += "\n" + this.QuantityLabel.Text;
        sWork += "\n" + this.ShippingCostLabel.Text;
        sWork += "\n" + this.TotalLabel.Text;
        sWork += "\n\n" + this.NameTextBox.Text;
        sWork += "\n" + this.StreetTextBox.Text;
        sWork += "\n" + this.CityTextBox.Text;
        sWork += " " + this.StateTextBox.Text;
        sWork += ", " + this.ZipTextBox.Text;

        MailMessage msg = new MailMessage("luisalvarez0121@gmail.com",
        this.EmailTextBox.Text);
        msg.Subject = "Your Order has bee processed";
        msg.Body = sWork;
        SmtpClient client = new SmtpClient();

        client.Credentials = new System.Net.NetworkCredential("luisalvarez0121@gmail.com", yourPassword);
        client.Host = "mail.gmail.com";

        try {
            client.Send(msg); 
          }
        catch (Exception ex) {
            string s = ex.ToString();
        }
        client = null;
        Session.Clear();
        Server.Transfer("OrderSuccess.aspx?");

    }
}