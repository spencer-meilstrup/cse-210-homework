using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = "F";
        Console.Write("What grade percentage did you get? ");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        string gradeSign = "";
        int lastdigit = percentage % 10;
        if (lastdigit >=7 && percentage <= 90 && percentage >= 60)
        {
            gradeSign = "+";
        }
        else if (lastdigit < 3 && percentage >= 60)
        {
            gradeSign = "-";
        }
        Console.WriteLine($"Your grade is {letter}{gradeSign}.");
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("Too bad you didn't pass. Good luck next time!");
        }
    }
}