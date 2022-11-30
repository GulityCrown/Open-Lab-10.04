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
        private int relaseDate;
        private int pages;
        public string Title { get { return title; } set { title = value; } }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public int RelaseDate
        {
            get => relaseDate;
            set
            {
                if ((value >= 2021) || (value <= 1450))
                {
                    relaseDate = -1;
                }
                else
                {
                    relaseDate = value;
                }
            }

        }
        public int Pages
        {
            get { return pages; }
            set
            {
                pages = value;
            }
        }
        public Book()
        {
            title = "-1";
            category = "-1";
            author = "-1";
            relaseDate = -1;
            pages = -1;
        }
        public Book(string xTitle, int xPages)
        {
            this.title = xTitle;
            this.category = "-1";
            this.author = "-1";
            this.relaseDate = -1;
            this.pages = xPages;
        }
        public Book(string xTitle, int xPages, string xCategory, string xAuthor, int xRelaseDate)
        {
            title = xTitle;
            category = xCategory;
            author = xAuthor;
            relaseDate = xRelaseDate;
            pages = xPages;
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
