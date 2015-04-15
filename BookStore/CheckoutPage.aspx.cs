using System;
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
}