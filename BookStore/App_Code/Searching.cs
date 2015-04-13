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
        results = new List<Book>();
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
            Book tempbook = new Book(b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7], b[8], b[9], b[10], b[11], b[12], b[13], b[14], b[15], b[16], b[17]);
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

    public void Search(string isbn, string title, string author, string semester, string course, string section, string professor, string crn)
    {
        if (isbn != "")
        {
            SearchByISBN(isbn);
        }
        if (title != "")
        {
            SearchByTitle(title);
        }
        if (author != "")
        {
            SearchByAuthor(author);
        }
        if (semester != "")
        {
            SearchBySemester(semester);
        }
        if (course != "")
        {
            SearchByCourse(course);
        }
        if (section != "")
        {
            SearchBySection(section);
        }
        if (professor != "")
        {
            SearchByProfessor(professor);
        }
        if (crn != "")
        {
            SearchByCRN(crn);
        }
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

    private void SearchByISBN(string i)
    {
        if (results.Count >= 1)
        {
            List<Book> tempList = new List<Book>();
            foreach (Book b in results)
            {
                if (b.ISBN() == i)
                {
                    tempList.Add(b);
                }
            }
            results.Clear();
            results.AddRange(tempList);
        }
        else
        {
            foreach (Book b in bookList)
            {
                if (b.ISBN() == i)
                {
                    results.Add(b);
                }
            }
        }
    }

    private void SearchByTitle(string tit)
    {
        if (results.Count >= 1)
        {
            List<Book> tempList = new List<Book>();
            foreach (Book b in results)
            {
                if (b.Title().Contains(tit))
                {
                    tempList.Add(b);
                }
            }
            results.Clear();
            results.AddRange(tempList);
        }
        else
        {
            foreach (Book b in bookList)
            {
                if (b.Title().Contains(tit))
                {
                    results.Add(b);
                }
            }
        }
    }

    private void SearchByAuthor(string auth)
    {
        if (results.Count >= 1)
        {
            List<Book> tempList = new List<Book>();
            foreach (Book b in results)
            {
                if (b.Author().Contains(auth))
                {
                    tempList.Add(b);
                }
            }
            results.Clear();
            results.AddRange(tempList);
        }
        else
        {
            foreach (Book b in bookList)
            {
                if (b.Author().Contains(auth))
                {
                    results.Add(b);
                }
            }
        }
    }

    private void SearchBySemester(string semest)
    {
        if (results.Count >= 1)
        {
            List<Book> tempList = new List<Book>();
            foreach (Book b in results)
            {
                if (b.Semester().Contains(semest))
                {
                    tempList.Add(b);
                }
            }
            results.Clear();
            results.AddRange(tempList);
        }
        else
        {
            foreach (Book b in bookList)
            {
                if (b.Semester().Contains(semest))
                {
                    results.Add(b);
                }
            }
        }
    }

    private void SearchByCourse(string cour)
    {
        if (results.Count >= 1)
        {
            List<Book> tempList = new List<Book>();
            foreach (Book b in results)
            {
                if (b.Course().Contains(cour))
                {
                    tempList.Add(b);
                }
            }
            results.Clear();
            results.AddRange(tempList);
        }
        else
        {
            foreach (Book b in bookList)
            {
                if (b.Title().Contains(cour))
                {
                    results.Add(b);
                }
            }
        }
    }

    private void SearchBySection(string sec)
    {
        if (results.Count >= 1)
        {
            List<Book> tempList = new List<Book>();
            foreach (Book b in results)
            {
                if (b.Section().Contains(sec))
                {
                    tempList.Add(b);
                }
            }
            results.Clear();
            results.AddRange(tempList);
        }
        else
        {
            foreach (Book b in bookList)
            {
                if (b.Section() == sec)
                {
                    results.Add(b);
                }
            }
        }
    }

    private void SearchByProfessor(string prof)
    {
        if (results.Count >= 1)
        {
            List<Book> tempList = new List<Book>();
            foreach (Book b in results)
            {
                if (b.Course().Contains(prof))
                {
                    tempList.Add(b);
                }
            }
            results.Clear();
            results.AddRange(tempList);
        }
        else
        {
            foreach (Book b in bookList)
            {
                if (b.Title().Contains(prof))
                {
                    results.Add(b);
                }
            }
        }
    }

    private void SearchByCRN(string c)
    {
        if (results.Count >= 1)
        {
            List<Book> tempList = new List<Book>();
            foreach (Book b in results)
            {
                if (b.CRN().Contains(c))
                {
                    tempList.Add(b);
                }
            }
            results.Clear();
            results.AddRange(tempList);
        }
        else
        {
            foreach (Book b in bookList)
            {
                if (b.CRN() == c)
                {
                    results.Add(b);
                }
            }
        }
    }
}