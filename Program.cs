using System;
using System.Runtime.CompilerServices;
using System.Transactions;

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

            //Circle circle = new Circle(2);
            //Console.WriteLine("The circle area of radius " +  circle.radius + " is "+ circle.getArea());

            //Create a BankAccount class with the following properties:
            //AccountNumber(string)
            //OwnerName(string)
            //Balance(double)
            //Implement the default constructor and a parameterized constructor that takes
            //values for all the properties.Additionally, implement methods to deposit and
            //withdraw funds from the account.


            //Console.WriteLine("<< Welcome To WhatIsFun Bank >>");
            //Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            //Console.WriteLine("Account Details:");
            //BankAccount bankAccount = new BankAccount("BC-2894","Mohammed",400);
            //Console.WriteLine("Account Number:" + bankAccount.AccountNumber);
            //Console.WriteLine("Account Owner: " + bankAccount.OwnerName);
            //Console.WriteLine("Account Balance: " + bankAccount.Balance);
            //Console.WriteLine(">>>>>>>>>>>>>>>>>>>>");
            //Console.WriteLine("Our Services: ");
            //Console.WriteLine("1. Deposit ");
            //Console.WriteLine("2. Withdraw ");
            //Console.WriteLine("3. Exit ");
            //Console.WriteLine("How can we serve you:");
            //int service = Convert.ToInt32(Console.ReadLine());
            //switch (service)
            //{
            //    case 1:
            //        Console.WriteLine("~~~ Deposit ~~~");
            //        Console.WriteLine("How much do you want to deposit: ");
            //        double amount = Convert.ToDouble(Console.ReadLine());
            //        bankAccount.Deposit(amount);
            //        Console.WriteLine("Thank you for using our services");

            //        break;

            //    case 2:
            //        Console.WriteLine("~~~ Withdraw ~~~");
            //        Console.WriteLine("How much do you want to withdraw: ");
            //        double amount1 = Convert.ToDouble(Console.ReadLine());
            //        bankAccount.Withdraw(amount1);
            //        Console.WriteLine("Thank you for using our services");

            //        break;
            //    case 3:
            //        Console.WriteLine("Thank you for using our services");
            //        Console.ReadLine();
            //        break;


            //}

            //Create an Employee class in with the following properties:
            //Name(string)
            //Position(string)
            //Salary(double)
            //Implement the default constructor and a parameterized constructor that
            //takes values for all the properties.

            Employee employee = new Employee("Mohammed", "IT maneger",3500);

            Console.WriteLine("<  < < << Employeer Details >> > >  >");
            Console.WriteLine("The employee name: "+employee.Name);
            Console.WriteLine("Position: "+employee.Position);
            Console.WriteLine("Salary: " +employee.Salary +"OMR");
        }
    }
}