using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

/// <summary>
/// Summary description for Checkout
/// </summary>
public class Checkout
{
    private Customer cust;
    private float orderPrice;
    private List<CartBook> orderBooks;
    private CreditCard cc;
    

	public Checkout(Customer c)
	{
        cust = c;
        orderPrice = cust.Cart().CartPrice();
        orderBooks = cust.Cart().CartBooks();

    }

     public void CreateCreditCard(string cn, string vn, DateTime d)
    {
        cc = new CreditCard(cn, vn, d);
    }

    public bool VerifyInfo ()
    {
        if(cc.ConfirmInfo())
        { 
            return true;
        }
        else 
        {
            return false;
        }
    }

    public void CompleteTransaction ()
    {

    }

    public List<CartBook> OrderBooks()
    {
        return orderBooks;
    }

    public float OrderPrice()
    {
        return orderPrice;
    }
}