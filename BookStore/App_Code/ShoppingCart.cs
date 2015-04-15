using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ShoppingCart
/// </summary>
public class ShoppingCart
{

    private List<CartBook> cartBooks;

    //testcode
    //private List<Book> bookList;
    Random r = new Random();
    //testcode

    public ShoppingCart()
    {
        cartBooks = new List<CartBook>();
        //testcode
        //bookList = new List<Book>();
        //GenerateBookList();
        // CartBookTest();
        //testcode
    }

    //testcode
    public void GenerateBookList()
    {
        //int counter = 0;
        string line;
        System.IO.StreamReader file = new System.IO.StreamReader(HttpContext.Current.Server.MapPath("~/App_Data/BookData/books.csv"));
        while ((line = file.ReadLine()) != null)
        {
            string[] b = line.Split(',');
            //Holy fuuuuck man look at all these arguments!
            Book tempbook = new Book(b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17]);
            AddBook(tempbook, 1, 50);
        }

        file.Close();
    }
    //testcode

    public float CartPrice()
    {
        float priceTemp = 0;
        float priceSum = 0;
        foreach (CartBook b in cartBooks)
        {
            priceTemp += b.GetPrice();
            priceTemp *= b.GetQuanity();
            priceSum += priceTemp;
            priceTemp = 0;
        }
        return priceSum;
    }


    public void AddBook(Book b, int t, int q)
    {
        CartBook tempbook = new CartBook(b, t, q);
        cartBooks.Add(tempbook);
    }
    public List <CartBook> CartBooks()
    {
        return cartBooks;
    }

    public void RemoveBook(CartBook b)
    {
        cartBooks.Remove(b);
    }

    /*public void CartBookTest()
    {
        foreach (Book b in bookList)
        {
            AddBook(b, r.Next(0, 3), r.Next(1, 3));

        }
    }*/





}