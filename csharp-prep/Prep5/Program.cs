using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");   
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite integer: ");
            int theNumber = int.Parse(Console.ReadLine());
            return theNumber;
        }
        static int PromptUserBirthYear()
        {
            Console.Write("Please enter your birth year: ");
            int birthYear = int.Parse(Console.ReadLine());
            return birthYear;
        }
        static int SquareNumber(int x)
        {
            int square = x*x;
            return square;
        }
        static void DisplayResult(string name, int birthYear, int numberSquared)
        {
            Console.WriteLine($"{name}, your favorite number squared is {numberSquared}");
            int age = 2026-birthYear;
            Console.WriteLine($"{name}, you will turn {age} this year.");
        }
        DisplayWelcome();
        string nameOfUser = PromptUserName();
        int favNumber = PromptUserNumber();
        int birthYear = PromptUserBirthYear();
        int squaredNumber = SquareNumber(favNumber);
        DisplayResult(nameOfUser, birthYear, squaredNumber);
    }
}