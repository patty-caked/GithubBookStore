﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CheckoutPage : System.Web.UI.Page
{
    private Checkout co;
    private Customer cust;
    protected void Page_Load(object sender, EventArgs e)
    {
       cust = (Customer)(Session["Customer"]);
       co = new Checkout(cust);
       

       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string cn = ccnumber.Text;
        string vn = ccverification.Text;
        int mon = Convert.ToInt32(month.SelectedValue);
        int yea = Convert.ToInt32(month.SelectedValue);
        DateTime dt = new DateTime(yea,mon,1);
        co.CreateCreditCard(cn,vn, dt);

        if (co.VerifyInfo())
        {
            Response.Redirect("CompleteOrder.aspx");
        }
        else
        {
            Response.Redirect("CheckoutPage.aspx");
        }

    }
}