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
        Searching serch = new Searching();
        Customer cust = (Customer)(Session["customer"]);
        //name.Text = cust.Username();
        //Label1.Text = serch.GetBooks();

        List<Book> b = serch.BookList();
    }
    protected void SearchButton_Click(object sender, EventArgs e)
    {
        string[] searchList;
        string input = isbn.Text + "," + title.Text + "," + author.Text + "," + semester.Text + "," + course.Text + "," + section.Text + "," + professor.Text + "," + crn.Text;
        searchList = input.Split(',');
        Session.Add("searchInput", searchList);

        Response.Redirect("SearchResults.aspx");
    }
}