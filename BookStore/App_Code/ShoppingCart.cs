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

	public ShoppingCart()
	{
        cartBooks = new List<CartBook>();

	}

    public float CartPrice ()
    {
        float tempPrice = 0;
        foreach(CartBook b in cartBooks)
            {
                tempPrice += b.GetPrice(b.GetType());
            }
        return tempPrice;
    }

    public void AddBook(Book b, int t, int q)
    {
        CartBook tempbook = new CartBook(b, t, q);
        cartBooks.Add(tempbook);
    }

    public void RemoveBook(CartBook b)
    {
        cartBooks.Remove(b);
    }





}