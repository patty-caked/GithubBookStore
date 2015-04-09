using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Search : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SearchList serch = new SearchList();
        Customer cust = (Customer)(Session["customer"]);
        name.Text = cust.Username();
        Label1.Text = serch.GetBooks();
    }
}