using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {


        // Asking for the magic number
        // Console.Write("what is the magic number? ");
        // string magical = Console.ReadLine();
        // int magicNumber = int.Parse(magical);
        // Console.WriteLine($"magic number: {magicNumber} ");

        string response = "yes";
        while (response == "yes")
        {
            Console.WriteLine("Welcome to the Guessing Game!");
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);
            Console.WriteLine($"Random number: {magicNumber}");

            int guess = 0;
            string answer = "";

            int attempt = 0;

            while (guess != magicNumber)
            {
                Console.Write("what is your guess? ");
                answer = Console.ReadLine();
                guess = int.Parse(answer);
                attempt++;

                if (guess == magicNumber)
                {
                    Console.WriteLine("You guessed it!");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower!");
                }
                else
                {
                    Console.WriteLine("Higher!");
                }
            }
            Console.WriteLine($"It took you {attempt} attempts to guess the magic number!");
            
        Console.WriteLine("Do you want to continue? ");
        response = Console.ReadLine();
        }
        Console.WriteLine("Thanks for playing!");
    }
}