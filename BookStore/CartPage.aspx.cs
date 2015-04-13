using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CartPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ShoppingCart cart = new ShoppingCart();
        Label1.Text = cart.CartPrice().ToString();
    }
}