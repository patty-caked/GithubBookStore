using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class SearchResults : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //userName = (String)(Session["username"]);
        string[] sl = (string[])(Session["SearchInput"]);
        Searching search = new Searching();

        //This will take the list of search arguments the user made and generate a list of results that match the search
        search.Search(sl[0], sl[1], sl[2], sl[3], sl[4], sl[5], sl[6], sl[7]);

        //resultList will be the list of results displayed on the page
        List<Book> resultList = search.ReturnResults();

        CreateResultTable(resultList, resultList.Count());

        FillRows(resultList);


        //resultsGrid.Rows[1].Cells[3].Text = "hello";
    }

    public void CreateResultTable(List<Book> b, int num)
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("ISBN");
        dt.Columns.Add("Title");
        dt.Columns.Add("Author");
        dt.Columns.Add("Semester");
        dt.Columns.Add("Course");
        dt.Columns.Add("Section");
        dt.Columns.Add("Professor");
        dt.Columns.Add("CRN");
        dt.Columns.Add("Required/Recommended");
        dt.Columns.Add("Cover");
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
            //ImageField imf = new ImageField();
            //Image img = new Image();
            //img.ImageUrl = Server.MapPath("~/App_Data/BookData/BookImages/" + b[i].ISBN() + ".jpg");
            dr["Cover"] = ResolveUrl("~/App_Data/BookData/BookImages/" + b[i].ISBN() + ".jpg");
            dt.Rows.Add(dr);
            dt.AcceptChanges();
        }
        resultsGrid.DataSource = dt;
        resultsGrid.DataBind();
    }

    /// <summary>
    /// This method will fill in the result table with the proper information about the results gathered from the search
    /// </summary>
    protected void FillRows(List<Book> b)
    {
        //resultsGrid.Rows[1].Cells[3].Text = "hello";
    }
}