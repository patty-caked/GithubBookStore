using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class CartPage : System.Web.UI.Page
{
    ShoppingCart cart;
    List<DropDownList> typelist;
    protected void Page_Load(object sender, EventArgs e)
    {
        typelist = new List<DropDownList>();
        cart = new ShoppingCart();
       // Label1.Text = cart.CartPrice().ToString();
        //Searching search = new Searching();
        CreateResultTable(cart.CartBooks(), cart.CartBooks().Count());
        TotalLabel.Text = cart.CartPrice().ToString();
        FillRows(cart.CartBooks(),cart.CartBooks().Count());
    }
    public void CreateResultTable(List<CartBook> b, int num)
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("Cover");
       // dt.Columns.Add("ISBN");
        dt.Columns.Add("Title");
        dt.Columns.Add("Author");
        dt.Columns.Add("Type");
        dt.Columns.Add("Price");
       // dt.Columns.Add("Semester");
       // dt.Columns.Add("Course");
       // dt.Columns.Add("Section");
       // dt.Columns.Add("Professor");
       // dt.Columns.Add("CRN");
       // dt.Columns.Add("Required/Recommended");
        //dt.Columns.Add(" ");


        //dt.Columns.Add(new DataColumn("Cover", typeof(ImageField)));
        //dt.Columns.Add("");
        for (int i = 0; i < num; i++)
        {
            DataRow dr = dt.NewRow();
           // dr["ISBN"] = b[i].GetBook().ISBN(); //"ISBN-" + i;
            dr["Title"] = b[i].GetBook().Title(); //"Title-" + i;
            dr["Author"] = b[i].GetBook().Author(); //"Author-" + i;
            dr["type"] = b[i].gettypestring();
            dr["price"] = b[i].GetPrice().ToString();
          //  dr["Semester"] = b[i].GetBook().Semester(); //"Semester-" + i;
          //  dr["Course"] = b[i].GetBook().Course(); //"Course-" + i;
          //  dr["Section"] = b[i].GetBook().Section(); //"Section-" + i;
          //  dr["Professor"] = b[i].GetBook().Professor(); //"Professor-" + i;
          //  dr["CRN"] = b[i].GetBook().CRN(); //"CRN-" + i;
          //  dr["Required/Recommended"] = b[i].GetBook().Requirement(); //"Required/Recommended-" + i;
            Image img = new Image();
            img.ImageUrl = Server.MapPath("~/App_Data/BookData/BookImages/" + b[i].GetBook().ISBN() + ".jpg");
            //img.ImageUrl = ResolveUrl("~/App_Data/BookData/BookImages/" + b[i].ISBN() + ".jpg");
            dr["Cover"] = ResolveUrl("~/App_Data/BookData/BookImages/" + b[i].GetBook().ISBN() + ".jpg");
          //  dr[" "] = " ";

            dt.Rows.Add(dr);
            dt.AcceptChanges();
        }
        Cart.DataSource = dt;
        Cart.DataBind();
    }
    protected void FillRows(List<CartBook> b, int num)
    {
        //resultsGrid.Rows[1].Cells[3].Text = "hello";
        for (int i = 0; i < num; i++)
        {
            //ImageField imf = new ImageField();
            ImageButton imgButt = new ImageButton();
            imgButt.ID = "Butt" + i;
            imgButt.ImageUrl = ResolveUrl(b[i].GetBook().ISBN() + ".jpg");
            Cart.Rows[i].Cells[0].Controls.Add(imgButt);

            DropDownList typeselect = new DropDownList();
            typeselect.ID = "t"+i;
            ListItem typea = new ListItem();
            ListItem typeb = new ListItem();
            ListItem typec = new ListItem();
            ListItem typed = new ListItem();
            ListItem typex = new ListItem();
            typex.Text = " ";
            typex.Value = "4";
            typea.Text = "new";
            typea.Value = "0";
            typeb.Text = "used";
            typeb.Value = "1";
            typec.Text = "rental";
            typec.Value = "2";
            typed.Text = "ebook";
            typed.Value = "3";
            typeselect.Items.Add(typex);
            typeselect.Items.Add(typea);
            typeselect.Items.Add(typeb);
            typeselect.Items.Add(typec);
            typeselect.Items.Add(typed);

            Cart.Rows[i].Cells[3].Controls.Add(typeselect);
            typelist.Add(typeselect);

            //button stuff
            //Button butt = new Button();
            //butt.GetRouteUrl()
        }
    }
    protected void CheckoutButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("Checkout.aspx");
    }
    protected void UpdateCart(object sender, EventArgs e)
    {
        updatetype();
        updateamount();
    }
    public void updatetype()
    {
        for (int i = 0; i < cart.CartBooks().Count(); i++)
        {
            if (typelist[i].SelectedIndex != 0)
                cart.CartBooks()[i].ChangeType(Convert.ToInt32(typelist[i].SelectedValue));
        }
    }
    public void updateamount()
    {
 
    }
}
