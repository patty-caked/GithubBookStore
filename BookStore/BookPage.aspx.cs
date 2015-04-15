using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BookPage : System.Web.UI.Page
{
    Customer cust;
    Book b;
    protected void Page_Load(object sender, EventArgs e)
    {
        b = (Book)(Session["book"]);
        cust = (Customer)(Session["customer"]);
        
        cover.ImageUrl = ResolveUrl(b.ISBN() + ".jpg");
        isbn.Text = b.ISBN();
        title.Text = b.Title();
        author.Text = b.Author();
        semester.Text = b.Semester();
        course.Text = b.Course();
        section.Text = b.Section();
        professor.Text = b.Professor();
        crn.Text = b.CRN();
        use.Text = b.Requirement();
        qnew.Text = b.QuantityNew().ToString();
        qused.Text = b.QuantityUsed().ToString();
        qrent.Text = b.QuantityRental().ToString();
        if (b.QuantityEBook() != 0)
        {
            qebook.Text = "available";
        }
        else
        {
            qebook.Text = "not available";
        }
        pnew.Text = b.PriceNew().ToString();
        pused.Text = b.PriceUsed().ToString();
        prent.Text = b.PriceRental().ToString();
        pebook.Text = b.PriceEBook().ToString();
        descript.Text = b.Description();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int i = Convert.ToInt32(typeList.SelectedValue);

        if (i != 4)
        {
            cust.Cart().AddBook(b, i, 1);
            Session.Add("customer", cust);
            Response.Redirect("CartPage.aspx");
        }
    }
}