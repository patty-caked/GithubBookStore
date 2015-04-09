using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

/// <summary>
/// Summary description for Book
/// </summary>
public class Book
{
    private int isbn;
    private string title;
    private string author;
    private string semester;
    private string course;
    private int section;
    private string professor;
    private int crn;
    private string requirement;
    private int quantityNew;
    private int quantityUsed;
    private int quantityRental;
    private int quantityEBook;
    private float priceNew;
    private float priceUsed;
    private float priceRental;
    private float priceEBook;
    private string description;
    //private int image;

    public Book(string i, string tit, string auth, string semest, string cour, string sect, string prof, string c, string req, string quantN, string quantU, string quantR, string quantE, string priceN, string priceU, string priceR, string priceE, string descrip)
	{
        isbn = Convert.ToInt32(i);
        title = tit;
        author = auth;
        semester = semest;
        course = cour;
        section = Convert.ToInt32(sect);
        professor = prof;
        crn = Convert.ToInt32(c);
        requirement = req;
        quantityNew = Convert.ToInt32(quantN);
        quantityUsed = Convert.ToInt32(quantU);
        quantityRental = Convert.ToInt32(quantR);
        quantityEBook = Convert.ToInt32(quantE);
        priceNew = Convert.ToSingle(priceN);
        priceUsed = Convert.ToSingle(priceU);
        priceRental = Convert.ToSingle(priceR);
        priceEBook = Convert.ToSingle(priceE);
        description = descrip;
	}

    public Book(int i, string tit, string auth, string semest, string cour, int sect, string prof, int c, string req, int quantN, int quantU, int quantR, int quantE, float priceN, float priceU, float priceR, float priceE, string descrip)
    {
        isbn = i;
        title = tit;
        author = auth;
        semester = semest;
        course = cour;
        section = sect;
        professor = prof;
        crn = c;
        requirement = req;
        quantityNew = quantN;
        quantityUsed = quantU;
        quantityRental = quantR;
        quantityEBook = quantE;
        priceNew = priceN;
        priceUsed = priceU;
        priceRental = priceR;
        priceEBook = priceE;
        description = descrip;
    }

    public int ISBN()
    {
        return isbn;
    }
    
    public string Title()
    {
        return title;
    }

    public string Author()
    {
        return author;
    }

    public string Semester()
    {
        return semester;
    }

    public string Course()
    {
        return course;
    }

    public int Section()
    {
        return section;
    }

    public string Professor()
    {
        return professor;
    }

    public int CRN()
    {
        return crn;
    }
    
    public string Requirement()
    {
        return requirement;
    }

    public int QuantityNew()
    {
        return quantityNew;
    }

    public int QuantityUsed()
    {
        return quantityUsed;
    }

    public int QuantityRental()
    {
        return quantityRental;
    }

    public int QuantityEBook()
    {
        return quantityEBook;
    }

    public float PriceNew()
    {
        return priceNew;
    }

    public float PriceUsed()
    {
        return priceUsed;
    }

    public float PriceRental()
    {
        return priceRental;
    }

    public float PriceEBook()
    {
        return priceEBook;
    }
}