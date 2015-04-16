using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.IO;

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

    public CreditCard CreditCard()
     {
         return cc;
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

    public void CreateReceipt()
    {
        StreamReader sr = new StreamReader(HttpContext.Current.Server.MapPath("~/App_Data/Receipt/Index.txt"));
        int index = Convert.ToInt32(sr.ReadLine());
        sr.Close();
        string ccNum = "Credit Card Number: " + cc.CcNum();
        string day = DateTime.Now.Day.ToString();
        string month = DateTime.Now.Month.ToString();
        string year = DateTime.Now.Year.ToString();
        string date = "Date: " + day + "/" + month + "/" + year;
        StreamWriter swR = new StreamWriter(HttpContext.Current.Server.MapPath("~/App_Data/Receipt/" + index + "receipt.txt"));
        swR.WriteLine(date);
        swR.WriteLine("Order Price: $" + orderPrice);
        swR.WriteLine(ccNum);
        swR.Close();
        index++;
        StreamWriter swI = new StreamWriter(HttpContext.Current.Server.MapPath("~/App_Data/Receipt/Index.txt"));
        swI.WriteLine(index);
        swI.Close();
    }
}