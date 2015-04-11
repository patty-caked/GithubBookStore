using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for User
/// </summary>
public class Customer
{

    private String username;
    private String password;
    ShoppingCart cart;

	public Customer(String u, String p)
	{
        username = u;
        password = p;
	}

    public bool IsValid()
    {
        if (password == "1234568")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public String Username()
    {
        return username;
    }

    public String Password()
    {
        return password;
    }

}