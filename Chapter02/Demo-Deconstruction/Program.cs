using Packtpub.KunalChowdhury.Demos.Models;
using System;

namespace Packtpub.KunalChowdhury.Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            //var bookDetails = GetBookDetails(); // returns Tuple
            //Console.WriteLine("Title  : " + bookDetails.Title);
            //Console.WriteLine("Author : " + bookDetails.Author);

            //(string title, string author) = GetBookDetails();
            //Console.WriteLine("Title  : " + title);
            //Console.WriteLine("Author : " + author);

            //(var title, var author) = GetBookDetails();
            //Console.WriteLine("Title  : " + title);
            //Console.WriteLine("Author : " + author);

            //var (title, author) = GetBookDetails();
            //Console.WriteLine("Title  : " + title);
            //Console.WriteLine("Author : " + author);

            var book = new Book();
            var (title, author) = book; // OR, var (title, author) = new Book();
            Console.WriteLine("Title  : " + title);
            Console.WriteLine("Author : " + author); Console.WriteLine();
        }

        public static (string Title, string Author) GetBookDetails()
        {
            return (Title: "Mastering Visual Studio 2017", Author: "Kunal Chowdhury");
        }
    }
}
