using System.Runtime.CompilerServices;

namespace cSharp_OOP_Practices
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Book book = new Book("Funny Stuff", " ", "WhatIsFun", 1997);
            Console.WriteLine("Book details> ");
            Console.WriteLine("Book title: "+ book.Title);
            Console.WriteLine("Book description: "+ book.Description);
            Console.WriteLine("Book Auther: "+ book.Author);
            Console.WriteLine("Book published year: "+ book.Year);

        }
    }
}