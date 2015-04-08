using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    //private bool lgFailed = false;
    protected void Page_Load(object sender, EventArgs e)
    {
        /*if (lgFailed == false)
        {
            userName = (String)(Session["username"]);
            name.Text = userName;
        }*/
    }
    protected void loginSubmit_Click(object sender, EventArgs e)
    {
        Customer cust = new Customer(username.Text, password.Text);
        Session.Add("customer", cust);
        //Session.Add("username", username.Text);
        //Session.Add("password", password.Text);
        if (cust.IsValid())
            Response.Redirect("Search.aspx");
        else
        {
            Response.Redirect("LoginFailed.aspx");
        }
    }
    protected void password_TextChanged(object sender, EventArgs e)
    {

    }
}