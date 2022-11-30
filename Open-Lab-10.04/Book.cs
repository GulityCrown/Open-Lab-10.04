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
            Title = "-1";
            Category = "-1";
            Author = "-1";
            RelaseDate = "-1";
            Pages = -1;
        }
        public Book(string xTitle, int xPages)
        {
            Title = xTitle;
            Category = "-1";
            Author = "-1";
            RelaseDate = "-1";
            Pages = xPages;
        }
        public Book(string xTitle, int xPages, string xCategory, string xAuthor, string xRelaseDate)
        {
            Title = xTitle;
            Category = xCategory;
            Author = xAuthor;
            RelaseDate = xRelaseDate;
            Pages = xPages;
        }



        public void Vypis()
        {
            Console.WriteLine();
            Console.WriteLine("Category: " + Category);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Relase date: " + RelaseDate);
            Console.WriteLine("number of pages: " + Pages);
            Console.WriteLine();
        }
    }
}
