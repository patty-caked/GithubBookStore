using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class SearchResults : System.Web.UI.Page
{
    List<Book> resultList;
    protected void Page_Load(object sender, EventArgs e)
    {
        //userName = (String)(Session["username"]);
        string[] sl = (string[])(Session["SearchInput"]);
        Searching search = new Searching();

        //This will take the list of search arguments the user made and generate a list of results that match the search
        search.Search(sl[0], sl[1], sl[2], sl[3], sl[4], sl[5], sl[6], sl[7]);

        //resultList will be the list of results displayed on the page
        resultList = search.ReturnResults();

        CreateResultTable(resultList, resultList.Count());

        FillRows(resultList, resultList.Count());

        //resultsGrid.Rows[1].Cells[3].Text = "hello";
    }

    public void CreateResultTable(List<Book> b, int num)
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("Cover");
        dt.Columns.Add("ISBN");
        dt.Columns.Add("Title");
        dt.Columns.Add("Author");
        dt.Columns.Add("Semester");
        dt.Columns.Add("Course");
        dt.Columns.Add("Section");
        dt.Columns.Add("Professor");
        dt.Columns.Add("CRN");
        dt.Columns.Add("Required/Recommended");
        dt.Columns.Add(" ");
        
        //dt.Columns.Add(new DataColumn("Cover", typeof(ImageField)));
        //dt.Columns.Add("");
        for (int i = 0; i < num; i++)
        {
            DataRow dr = dt.NewRow();
            dr["ISBN"] = b[i].ISBN(); //"ISBN-" + i;
            dr["Title"] = b[i].Title(); //"Title-" + i;
            dr["Author"] = b[i].Author(); //"Author-" + i;
            dr["Semester"] = b[i].Semester(); //"Semester-" + i;
            dr["Course"] = b[i].Course(); //"Course-" + i;
            dr["Section"] = b[i].Section(); //"Section-" + i;
            dr["Professor"] = b[i].Professor(); //"Professor-" + i;
            dr["CRN"] = b[i].CRN(); //"CRN-" + i;
            dr["Required/Recommended"] = b[i].Requirement(); //"Required/Recommended-" + i;
            Image img = new Image();
            img.ImageUrl = Server.MapPath("~/App_Data/BookData/BookImages/" + b[i].ISBN() + ".jpg");
            //img.ImageUrl = ResolveUrl("~/App_Data/BookData/BookImages/" + b[i].ISBN() + ".jpg");
            dr["Cover"] = ResolveUrl("~/App_Data/BookData/BookImages/" + b[i].ISBN() + ".jpg");
            dr[" "] = " ";

            dt.Rows.Add(dr);
            dt.AcceptChanges();
        }
        resultsGrid.DataSource = dt;
        resultsGrid.DataBind();
    }

    /// <summary>
    /// Adds the image files to the DataList
    /// </summary>
    protected void FillRows(List<Book> b,int num)
    {
        //resultsGrid.Rows[1].Cells[3].Text = "hello";
        for (int i = 0; i < num; i++)
        {
            //ImageField imf = new ImageField();
            ImageButton imgButt = new ImageButton();
            imgButt.ID = "" + i;
            
            imgButt.ImageUrl = ResolveUrl(b[i].ISBN() + ".jpg");
            resultsGrid.Rows[i].Cells[0].Controls.Add(imgButt);
            
            //imgButt.OnClientClick = "Butt_Click";
            //imgButt.Attributes.Add("onclick", "Butt_Click");
            imgButt.Click += Butt_Click;
            //figure out how to add books to the cart
            //imgButt.run
            //button stuff
            //Button butt = new Button();
            //butt.GetRouteUrl()
        }
    }

    private void Butt_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton temp = sender as ImageButton;
        Session.Add("book", resultList[Convert.ToInt32(temp.ID)]);
        Response.Redirect("BookPage.aspx");
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Session.Add("book", resultList[0]);
        Response.Redirect("BookPage.aspx");
    }

}