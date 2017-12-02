using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ShopppingCart : System.Web.UI.Page
{
    List<Book> shoppingCart;
    



    protected void Page_Load(object sender, EventArgs e)
    {
       
        updateShoppingCart();
        fillTable();

    }

    void updateShoppingCart()
    {
         shoppingCart = (List<Book>)Session["shoppingCart"];
        if(shoppingCart == null)
        {
            shoppingCart = new List<Book>();
        }
    }
    void fillTable()
    {
        List<string> books = new List<string>();
        int Quantitytotal = 0;
        double Totalweight = 0;
        double Totalcost = 0;

       
        TableRow labelRow = new TableRow();
        TableCell namelabelCell = new TableCell();
        TableCell pricelabelCell = new TableCell();
        TableCell quantitylabelCell = new TableCell();
        TableCell totalCostLabelCell = new TableCell();
        TableCell weightLabelCell = new TableCell();
        TableCell removeFillerCell = new TableCell();



        namelabelCell.Text = "Title";
        pricelabelCell.Text = "Price";
        quantitylabelCell.Text = "Quantity";
        totalCostLabelCell.Text = "Total Cost";
        weightLabelCell.Text = "Weight";

        labelRow.Controls.Add(namelabelCell);
        labelRow.Controls.Add(pricelabelCell);
        labelRow.Controls.Add(quantitylabelCell);
        labelRow.Controls.Add(totalCostLabelCell);
        labelRow.Controls.Add(weightLabelCell);
        labelRow.Controls.Add(removeFillerCell);
        tbl.Controls.Add(labelRow);

        tbl.CssClass = "table table-striped";

       
       


        int cnt = 0;
        foreach (Book book in shoppingCart)
        {


           

            if (!books.Contains(book.Title))
            {
                books.Add(book.Title);
                TableRow row = new TableRow();
                TableCell nameCell = new TableCell();
                TableCell priceCell = new TableCell();
                TableCell QuantityCell = new TableCell();
                TableCell TotalCell = new TableCell();
                TableCell weightCell = new TableCell();

                TableCell removeCell = new TableCell();
                Button removeButton = new Button();
                removeButton.CssClass = "btn btn-primary";
                removeButton.Text = "Remove Item";

                row.ID = book.Title;


                removeButton.CommandArgument = cnt.ToString();

                removeButton.Click += new EventHandler(removeClick);


                QuantityCell.Text = "1";
                Quantitytotal += 1;

                nameCell.Text = book.Title;
                priceCell.Text = book.Price.ToString();

                TotalCell.Text = book.Price.ToString();
                Totalcost += book.Price;

                weightCell.Text = book.Weight.ToString();
                Totalweight += book.Weight;

                removeCell.Controls.Add(removeButton);


                row.Controls.Add(nameCell);
                row.Controls.Add(priceCell);
                row.Controls.Add(QuantityCell);
                row.Controls.Add(TotalCell);
                row.Controls.Add(weightCell);
                row.Controls.Add(removeCell);

                tbl.Controls.Add(row);
                cnt++;
            }
            else {
                Quantitytotal += 1;
                Totalweight += book.Weight;
                Totalcost += book.Price;
                double bookWeight = book.Weight;
                double bookPrice = book.Price;
                double curBookWeight = double.Parse(((TableRow)tbl.FindControl(book.Title)).Cells[2].Text);
                double curBookPrice = double.Parse(((TableRow)tbl.FindControl(book.Title)).Cells[2].Text);
                
                ((TableRow)tbl.FindControl(book.Title)).Cells[2].Text = (Int32.Parse(((TableRow)tbl.FindControl(book.Title)).Cells[2].Text)+1).ToString();
                ((TableRow)tbl.FindControl(book.Title)).Cells[3].Text =  (curBookPrice + bookPrice).ToString();
                 ((TableRow)tbl.FindControl(book.Title)).Cells[4].Text =  (curBookWeight+ bookWeight).ToString();

            }



        }

        Session["TotalWeight"] = Totalweight;
        Session["QuantityTotal"] = Quantitytotal;
        Session["TotalCost"] = Totalcost;

        TableRow countRow = new TableRow();
        TableCell filler1 = new TableCell();
        TableCell filler2 = new TableCell();
        TableCell totalCountCell = new TableCell();
        TableCell FinalCostCell = new TableCell();
        TableCell totalWeightCell = new TableCell();

        filler2.Text = "Cart Totals:";

        totalCountCell.Text = Quantitytotal.ToString();
        FinalCostCell.Text = Totalcost.ToString();
        totalWeightCell.Text = Totalweight.ToString();

        countRow.Controls.Add(filler1);
        countRow.Controls.Add(filler2);
        countRow.Controls.Add(totalCountCell);
        countRow.Controls.Add(FinalCostCell);
        countRow.Controls.Add(totalWeightCell);
        tbl.Controls.Add(countRow);

    }

   

    
   
   
    protected void removeClick(Object sender,EventArgs e)
    {
        Button button = (Button)sender;
        int index = int.Parse(button.CommandArgument);  
        List<Book> shoppingCart = (List<Book>)Session["shoppingCart"];

        shoppingCart.RemoveAt(index);

        Session["shoppingCart"] = shoppingCart;
        Server.Transfer("ShoppingCart.aspx?");
    }

    protected void CheckoutButton_Click(object sender, EventArgs e)
    {
        string queryString = "Checkout.aspx?";
        Server.Transfer(queryString);
    }

    protected void ShoppingButton_Click(object sender, EventArgs e)
    {
        
        Server.Transfer("Default.aspx?");
    }
}