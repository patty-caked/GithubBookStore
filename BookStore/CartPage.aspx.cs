using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class CartPage : System.Web.UI.Page
{
    //ShoppingCart cart;
    List<DropDownList> typelist;
    Customer cust;
    protected void Page_Load(object sender, EventArgs e)
    {
        cust = (Customer)(Session["customer"]);
        typelist = new List<DropDownList>();
       // Label1.Text = cart.CartPrice().ToString();
        //Searching search = new Searching();
        CreateResultTable(cust.Cart().CartBooks(), cust.Cart().CartBooks().Count());
        TotalLabel.Text = cust.Cart().CartPrice().ToString();
        FillRows(cust.Cart().CartBooks(), cust.Cart().CartBooks().Count());
    }
    public void CreateResultTable(List<CartBook> b, int num)
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("Cover");
        dt.Columns.Add("Title");
        dt.Columns.Add("Author");
        dt.Columns.Add("Type");
        dt.Columns.Add("Price");
        dt.Columns.Add("remove");


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
            Image img = new Image();
            img.ImageUrl = Server.MapPath("~/App_Data/BookData/BookImages/" + b[i].GetBook().ISBN() + ".jpg");
            dr["Cover"] = ResolveUrl("~/App_Data/BookData/BookImages/" + b[i].GetBook().ISBN() + ".jpg");
            dr["remove"] = "";
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

            Button remove = new Button();
            Cart.Rows[i].Cells[5].Controls.Add(remove);
            remove.ID = "" + i;
            remove.Text = "remove item";
            remove.Click += removebutton;

         /*   DropDownList typeselect = new DropDownList();
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
*/
            //button stuff
            //Button butt = new Button();
            //butt.GetRouteUrl()
        }
    }
    protected void CheckoutButton_Click(object sender, EventArgs e)
    {
        Session.Add("customer", cust);
        Response.Redirect("CheckoutPage.aspx");
    }
    protected void UpdateCart(object sender, EventArgs e)
    {
        updatetype();
        //updateamount();
        Session.Add("customer", cust);
    }
    public void removebutton(object sender, EventArgs e)
    {
        Button remove = sender as Button;
        cust.Cart().CartBooks().RemoveAt(Convert.ToInt32(remove.ID));
        //Updatesessionvariable
        Session.Add("customer", cust);

        Response.Redirect("CartPage.aspx");
    }
    public void updatetype()
    {
        for (int i = 0; i < cust.Cart().CartBooks().Count(); i++)
        {
            if (typelist[i].SelectedIndex != 0)
            {
                //Session.Add("customer", cust);
                cust.Cart().CartBooks()[i].ChangeType(Convert.ToInt32(typelist[i].SelectedValue));
            }
        }
    }

    public void updateamount()
    {
 
    }
}
