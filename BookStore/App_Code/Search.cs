using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Web;

/// <summary>
/// Used for Searching
/// </summary>
public class Search
{

    private List<Book> results;

	public Search()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public String GetBooks()
    {
        int counter = 0;
        string line;
        System.IO.StreamReader file = new System.IO.StreamReader("c:\\BookData\books.csv");
        /*while ((line = file.ReadLine()) != null)
        {
            
        }*/
        string/*[]*/ words = "e11*70/157*1999/101*1090*04"; //.Split('*');
        return words;

    }

    public void SearchByTitle()
    {
        throw new System.NotImplementedException();
    }

    public void SearchByAuthor()
    {
        throw new System.NotImplementedException();
    }

    public void SearchByISBN()
    {
        throw new System.NotImplementedException();
    }

    public void SearchByCourse()
    {
        throw new System.NotImplementedException();
    }

    public void SearchByProfessor()
    {
        throw new System.NotImplementedException();
    }

    public void SearchByCRN()
    {
        throw new System.NotImplementedException();
    }

    public void ReturnResults()
    {
        throw new System.NotImplementedException();
    }

    public void AddBookToResults()
    {
        throw new System.NotImplementedException();
    }

}