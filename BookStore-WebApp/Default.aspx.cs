using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        GetItems();
    }

    protected void GetItems()
    {
        OleDbConnection cn;
        OleDbCommand cmd;
        OleDbDataReader dr;

        Table tbl = new Table();
        tbl.CssClass = "table table-striped";
        TableRow row = new TableRow();
        try
        {

            cn = new OleDbConnection();
            if (Request.UserHostAddress.ToString().Equals("::1"))
            {
                cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\L-Dogg's\Documents\Books.accdb;Persist Security Info=False;";
            }

            else
            {
                cn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = h:\root\home\lalvarez2-002\www\site1\Books.accdb;
                    Persist Security Info = False;";

            }
        }

        catch (Exception err)
        {
            return;
        }




        cmd = new OleDbCommand("SELECT * FROM Books", cn);
        cn.Open();

        dr = cmd.ExecuteReader();


        while (dr.Read())
        {
            
            string title = dr["Title"].ToString();
            string image = dr["Image"].ToString();
            string author = dr["Author"].ToString();
            string price = dr["Price"].ToString();
            string desc = dr["Desc"].ToString();
            string weight = dr["Weight"].ToString();

            TableCell cell = new TableCell();
            ImageButton ib = new ImageButton();
            ib.ImageUrl = image;
            ib.CssClass = "img-rounded";
            ib.AlternateText = title;
            ib.Attributes.Add("title", title);
            ib.Attributes.Add("image",image);
            ib.Attributes.Add("author", author);
            ib.Attributes.Add("price", price);
            ib.Attributes.Add("desc", desc);
            ib.Attributes.Add("weight", weight);
            ib.Width = 100;
            ib.Height = 200;
           

            ib.Click += new ImageClickEventHandler(ib_Click);

            Label titleLabel = new Label();
            Label authorLabel = new Label();
            Label priceLabel = new Label();


            titleLabel.Text = title;
            authorLabel.Text = author;
            priceLabel.Text = "Ebook $" + price;

            cell.Controls.Add(ib);
            cell.Controls.Add(new LiteralControl("<br/>"));
            cell.Controls.Add(titleLabel);
            cell.Controls.Add(new LiteralControl("<br/>"));
            cell.Controls.Add(authorLabel);
            cell.Controls.Add(new LiteralControl("<br/>"));
            cell.Controls.Add(priceLabel);

            //cell.BorderWidth = 20;
            //cell.BorderStyle = BorderStyle.Ridge;
            //row.BorderStyle = BorderStyle.Ridge;

            row.Cells.Add(cell);
            tbl.Rows.Add(row);
            //tbl.BorderStyle = BorderStyle.Solid;
            

        }
        Panel1.Controls.Add(tbl);
        dr.Close();
        cn.Close();

    }

    protected void ib_Click(object sender, EventArgs e)
    {
        ImageButton ib = (ImageButton)sender;

        string queryString = "Details.aspx?"; 
        queryString += "title=" + Server.UrlEncode(ib.Attributes["title"])+ "&image=" + Server.UrlEncode(ib.Attributes["image"]) + "&author=" + Server.UrlEncode(ib.Attributes["author"]) + "&price=" + Server.UrlEncode(ib.Attributes["price"]) + "&desc=" + Server.UrlEncode(ib.Attributes["desc"]) + "&weight=" + Server.UrlEncode(ib.Attributes["weight"]);

        Server.Transfer(queryString);
    }
}