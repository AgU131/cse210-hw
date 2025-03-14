using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask for their grade percentage
        Console.Write("What is your grade percentage? ");
        string gradePercent = Console.ReadLine();
        int percent = int.Parse(gradePercent);

        // Calculate grade in a letter
        char letter = 'F';
        if (percent >= 90)
        {
            letter = 'A';
        }
        else if (percent >= 80)
        {
            letter = 'B';
        }
        else if (percent >= 70)
        {
            letter = 'C';
        }
        else if (percent >= 60)
        {
            letter = 'D';
        }
        else
        {
            letter = 'F';
        }

        Console.WriteLine($"You got an {letter}.");

        // Last motivational message acordign to the grade
        if (percent >= 70)
        {
            Console.WriteLine("Great job! You passed the class! Keep up the good work!");
        }
        else
        {
            Console.WriteLine("You didin't pass the class. Don't give up! You need to study more!");
        }
    }
}