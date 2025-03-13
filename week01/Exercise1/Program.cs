using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        // Ask for the first name
        Console.WriteLine("What is your first name? ");
        string firstName = Console.ReadLine();

        // Ask for the last name
        Console.WriteLine("What is your last name? ");
        string lastName = Console.ReadLine();

        // Return the full name
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}