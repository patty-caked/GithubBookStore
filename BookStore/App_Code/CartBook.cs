using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CartBook
/// </summary>
public class CartBook
{
    enum Type { New, Used, Rental, EBook }
    
    private Book book;
    int type;
    int quantity;

	public CartBook(Book b, int t, int q)
	{
        book = b;
        type = t;
        if (type == 3)
            quantity = 1;
        else
            quantity = q;
	}

    public void ChangeType(int t)
    {
        type = t;
    }

    public void ChangeAmount(int q)
    {
        quantity = q;
    }

    public Book GetBook()
    {
        return book;
    }

    public int GetType()
    {
        return type;
    }

    public int GetQuanity()
    {
        return quantity;
    }

    public float GetPrice(int t)
    {
        switch(t)
        {
            case 0:
                return book.PriceNew();

            case 1:
                return book.PriceUsed();

            case 2:
                return book.PriceRental();

            case 3:
                return book.PriceEBook();
            
            default:
                return 0;
        }
    }
}