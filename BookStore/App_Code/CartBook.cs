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
    Type type;
    int quantity;

	public CartBook(Book b, Type t, int q)
	{
        book = b;
        type = t;
        quantity = q;
	}

    public void ChangeType(Type t)
    {
        if (t == Type.EBook)
        type = t;
    }
}