using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Book
/// </summary>
public class Book
{
    private string title;
    private string image;
    private double price;
    private string desc;
    private string author;
    private double weight;
  

   
    public Book(string title, string image,double price, string desc,string author,double weight)
    {
        this.Title = title;
        this.Image = image;
        this.Price = price;
        this.Desc = desc;
        this.Author = author;
        this.Weight = weight;
        
    }

    public string Title
    {
        get
        {
            return title;
        }

        set
        {
            title = value;
        }
    }

    public string Image
    {
        get
        {
            return image;
        }

        set
        {
            image = value;
        }
    }

    public double Price
    {
        get
        {
            return price;
        }

        set
        {
            price = value;
        }
    }

    public string Desc
    {
        get
        {
            return desc;
        }

        set
        {
            desc = value;
        }
    }

    public string Author
    {
        get
        {
            return author;
        }

        set
        {
            author = value;
        }
    }

    public double Weight
    {
        get
        {
            return weight;
        }

        set
        {
            weight = value;
        }
    }
}