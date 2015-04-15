using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BookPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Book b = (Book)(Session["book"]);

        cover.ImageUrl = ResolveUrl(b.ISBN() + ".jpg");
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
}