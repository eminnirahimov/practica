using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBiblio
{
    class Program
    {
        static void Main(string[] args)
        {
            Books bks = new Books();
            for (int i = 0; i < 3; i++) bks.Add();
            bks.SearchByAuthor("Гугл");
            bks.DeleteByAuthor("Яндекс");
            bks.SearchByAuthor("а");
            Console.ReadKey();
        }

    }
    
    class Book
    {
        private string Name, ISBN, Autor;

        public Book()
        {
            Console.Write("\nДобавим книгу:\n Введите название:"); 
            Name = Console.ReadLine();
            Console.Write("Введите автора:");
            Autor = Console.ReadLine();
            Console.Write("Введите ISBN");
            ISBN = Console.ReadLine();
        }
        public bool IsName(string aName)
        {
            return Name == aName || aName == "";
        }
        public bool IsAutor(string aAutor)
        {
            return Name == aAutor || aAutor == "";
        }
        public bool IsISBN(string aISBN)
        {
            return Name == aISBN || aISBN == "";
        }
        public void Write()
        {
            Console.WriteLine("Book: {0,20}{1,20}{2,20}", Name, Autor, ISBN);
        }
    }

    class Books
    {
        List<Book> ListBooks;
        public Books() { ListBooks = new List<Book>(); }
        public void Add() { ListBooks.Add(new Book()); }
        public void SearchByAuthor(string cond)
        {
            foreach (Book b in ListBooks.Where(i => i.IsAutor(cond))) b.Write(); 
        }
        public void DeleteByAuthor(string cond)
        {
            ListBooks = ListBooks.Where(i => !i.IsAutor(cond)).ToList<Book>();
        }
    }

    /*class book
    {
        public int publication_year;
        public string name;
        public string author;
        public string cathegory;

        public book(int _year, string _name, string _author, string _cathegory)
        {
            publication_year = _year;
            name = _name;
            author = _author;
            cathegory = _cathegory;
        }

    }
    class Library
    {
        book[] library;

        public Library(int n)
        {
            library = new book[n];
        }

        public book Search(string name)
        {
            int index = 1;
            return library[index];
        }
        public book search(string author)
        {
            int index = 1;
            return library[index];
        }
        public book Sarch(string cathegory)
        {
            int index = 1;
            return library[index];
        }
        public book search(int year)
        {
            int index = 1;
            return library[index];
        } 
    }
    */
    

}
