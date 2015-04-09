using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Web;

/// <summary>
/// Used for Searching
/// </summary>
public class SearchList
{
    private List<Book> bookList;
    private List<Book> results;

	public SearchList()
	{
		
	}

    public List<Book> GenerateBookList()
    {
        int counter = 0;
        string line;
        System.IO.StreamReader file = new System.IO.StreamReader(HttpContext.Current.Server.MapPath("~/App_Data/BookData/books.csv"));
        while ((line = file.ReadLine()) != null)
        {
            string[] b = line.Split(',');
            Book tempbook = new Book(b[0],b[1],b[2],b[3],b[4],b[5],b[6],b[7],b[8],b[9],b[10],b[11],b[12],b[13],b[14],b[15],b[16],b[17]);
            bookList.Add();
        }
        //string[] words = file.ReadLine().Split(',');

        file.Close();


        return b;
    }

    public String GetBooks()
    {
        int counter = 0;
        string[] line;
        System.IO.StreamReader file = new System.IO.StreamReader(HttpContext.Current.Server.MapPath("~/App_Data/BookData/books.csv"));
        /*while ((line = file.ReadLine()) != null)
        {
            
        }*/
        string[] words = file.ReadLine().Split(',');


        file.Close();
        
        return words[0];


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