using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Details : System.Web.UI.Page
{
    List<Book> shoppingCart = new List<Book>();


    protected void Page_Load(object sender, EventArgs e) { 
        string image = Request.QueryString["image"];
        string title = Request.QueryString["title"];
        string price = Request.QueryString["price"];
        string author = Request.QueryString["author"];
        string desc = Request.QueryString["desc"];
        string weight = Request.QueryString["weight"];

        



        Table tbl = new Table();
        tbl.CssClass = "table table-striped";
        TableRow row = new TableRow();
        TableCell firstCell = new TableCell();
        TableCell secondCell = new TableCell();

        if (image != null)
        {
            Image bookImage = new Image();
            bookImage.ImageUrl = image;

            bookImage.Width = 183;
            bookImage.Height = 275;
            firstCell.Controls.Add(bookImage);
        }
        

       

        Label descLabel = new Label();
        descLabel.Text = desc;

        secondCell.Controls.Add(descLabel);

        secondCell.Width = 200;
        
        row.Cells.Add(secondCell);
        row.Cells.Add(firstCell);

        

        


        tbl.Rows.Add(row);
        Panel1.Controls.Add(tbl);
    }

    protected Book makeBook(string title,string image, string price,string desc,string author, string weight)
    {
        return new Book(title, image, double.Parse(price), desc,author,double.Parse(weight));
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string image = Request.QueryString["image"];
        string title = Request.QueryString["title"];
        string price = Request.QueryString["price"];
        string author = Request.QueryString["author"];
        string desc = Request.QueryString["desc"];
        string weight = Request.QueryString["weight"];
        
        int quantity = Int32.Parse(DropDownList1.SelectedItem.Text);
        Book book = makeBook(title, image, price, desc, author,weight);

        for (int i = 0; i < quantity; i++) {

            updateShoppingCart(book);
        }

        string queryString = "ShoppingCart.aspx?";
        Server.Transfer(queryString);

    }

    void updateShoppingCart(Book book)
    {
        shoppingCart = (List<Book>)Session["shoppingCart"];
        if (shoppingCart == null)
        {
            shoppingCart = new List<Book>();
        }
        shoppingCart.Add(book);
        Session["shoppingCart"] = shoppingCart;

    }
}