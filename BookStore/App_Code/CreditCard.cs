using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CreditCard
/// </summary>
public class CreditCard
{

    private string ccNum;
    private string verificationNum;
    private DateTime expDate;

    public CreditCard(string cn, string vn, DateTime d)
    {
        ccNum = cn;
        verificationNum = vn;
        expDate = d;
    }

    public bool ConfirmInfo()
    {
        //Check to make sure the expiration date is in the future, the ccNum is 16 digits, and the verification number is 777
        if (ccNum.Length == 14)
        {
            if (verificationNum == "777")
            {
                DateTime now = DateTime.Now;
                int test = DateTime.Compare(expDate, now);
                if (test == 1)
                {
                    return true;
                }
                else
                    return false;
            }
            return false;
        }
        else
            return false;
        
        //DateTime now = DateTime.Now;
        //int test = DateTime.Compare(expDate, now);
    }

    public string CcNum()
    {
        return ccNum;
    }
    
}