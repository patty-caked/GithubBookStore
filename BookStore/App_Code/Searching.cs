using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Web;

/// <summary>
/// Used for Searching
/// </summary>
public class Searching
{
    private List<Book> bookList;
    private List<Book> results;

	public Searching()
	{
        bookList = new List<Book>();
        GenerateBookList();
	}

    public void GenerateBookList()
    {
        //int counter = 0;
        string line;
        System.IO.StreamReader file = new System.IO.StreamReader(HttpContext.Current.Server.MapPath("~/App_Data/BookData/books.csv"));
        while ((line = file.ReadLine()) != null)
        {
            string[] b = line.Split(',');
            //Holy fuuuuck man look at all these arguments!
            Book tempbook = new Book(b[0],b[1],b[2],b[3],b[4],b[5],b[6],b[7],b[8],b[9],b[10],b[11],b[12],b[13],b[14],b[15],b[16],b[17]);
            bookList.Add(tempbook);
        }

        file.Close();
    }

    public String GetBooks()
    {
        string[] line;
        System.IO.StreamReader file = new System.IO.StreamReader(HttpContext.Current.Server.MapPath("~/App_Data/BookData/books.csv"));
        /*while ((line = file.ReadLine()) != null)
        {
            
        }*/
        string[] words = file.ReadLine().Split(',');

        file.Close();
        
        return words[0];
    }

    public List<Book> ReturnResults()
    {
        return results;
    }

    public List<Book> BookList()
    {
        return bookList;
    }

    public void AddBookToResults(Book b)
    {
        results.Add(b);
    }

    public void RemoveBookFromResults(Book b)
    {
        results.Remove(b);
    }

    public void Search(string isbn, string title, string author, string semester, string course, string section, string professor, string crn, string required)
    {
        if (isbn != "")
        {

        }
    }

    public void SearchByISBN()
    {
        foreach (Book b in bookList)
        {

        }
    }

    public void SearchByTitle()
    {
        throw new System.NotImplementedException();
    }

    public void SearchByAuthor()
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

    

}