using System.Runtime.CompilerServices;

namespace cSharp_OOP_Practices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Create a Book class with the following properties:
            Title(string)
            Author(string)
            Year(int)
            Implement the default constructor and a parameterized constructor that takes values for all the properties.*/

            //Book book = new Book("Funny Stuff", " ", "WhatIsFun", 1997);
            //Console.WriteLine("Book details> ");
            //Console.WriteLine("Book title: "+ book.Title);
            //Console.WriteLine("Book description: "+ book.Description);
            //Console.WriteLine("Book auther: "+ book.Author);
            //Console.WriteLine("Book published year: "+ book.Year);

            /*Create a Circle class with the following properties:
            Radius (double)
            Implement the default constructor and a parameterized constructor 
            that takes the radius as a parameter. Additionally, implement a method 
            to calculate and return the area of the circle.*/

            Circle circle = new Circle(2);
            Console.WriteLine("The circle area of radius " +  circle.radius + " is "+ circle.getArea());
        }
    }
}