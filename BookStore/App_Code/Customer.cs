using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for User
/// </summary>
public class Customer
{


    private String passwordEntered;
    private String passwordValid;
    private String usernameEntered;
    private List<String> usernamesValid;
    private string usernameTemp;
    ShoppingCart cart;

	public Customer(String u, String p)
	{
        usernameEntered = u;
        passwordEntered = p;
        usernamesValid = new List<string>();
	}

    public bool IsValid()
    {
        StreamReader srp = new StreamReader(HttpContext.Current.Server.MapPath("~/App_Data/Password.txt"));
        string passwordValid = srp.ReadLine();
        srp.Close();

        StreamReader sru = new StreamReader(HttpContext.Current.Server.MapPath("~/App_Data/Email.txt"));
        for(int i = 0; i <= 8; i++)
        {
            string usernameTemp = sru.ReadLine();
            usernamesValid.Add(usernameTemp);
        }
        sru.Close();

        if (passwordEntered == passwordValid)
        {
            if (usernamesValid.Contains(usernameEntered))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }

    public String Username()
    {
        return usernameEntered;
    }

    public String Password()
    {
        return passwordEntered;
    }
    public ShoppingCart Cart()
    {
        return cart;
    }
<<<<<<< HEAD

=======
>>>>>>> 235b85795ee6290e78f4b792587764755146592b
}