using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_10._04
{
    internal class Book
    {
        private string title;
        private string category;
        private string author;
        private string relaseDate;
        private int pages;
        public string Title { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
        public string RelaseDate { get; set; }
        public int Pages { get; set; }
        public Book()
        {
            this.title = "-1";
            this.category = "-1";
            this.author = "-1";
            this.relaseDate = "-1";
            this.pages = -1;
        }
        public Book(string xTitle, int xPages)
        {
            this.title = xTitle;
            this.category = "-1";
            this.author = "-1";
            this.relaseDate = "-1";
            this.pages = xPages;
        }
        public Book(string xTitle, int xPages, string xCategory, string xAuthor, string xRelaseDate)
        {
            this.title = xTitle;
            this.category = xCategory;
            this.author = xAuthor;
            this.relaseDate = xRelaseDate;
            this.pages = xPages;
        }



        public void Vypis()
        {
            Console.WriteLine();
            Console.WriteLine("Category: " + category);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Relase date: " + relaseDate);
            Console.WriteLine("number of pages: " + pages);
            Console.WriteLine();
        }
    }
}
