using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";
        while (response == "yes")
        {
            string matchingNumber = "wrong";
            Random randomGenerator = new Random();
            int theNumber = randomGenerator.Next(1,100);
            int turnCount = 0;
            while (matchingNumber == "wrong")
            {
                Console.Write("What number am I thinking of? ");
                string userInput = Console.ReadLine();
                turnCount += 1;
                int inputNumber = int.Parse(userInput);
                if (inputNumber == theNumber)
                {
                    matchingNumber = "correct";
                    Console.WriteLine($"You guessed my number in {turnCount} guesses!");
                    Console.Write("Do you want to keep playing? ");
                    response = Console.ReadLine();
                }
                else if (inputNumber < theNumber)
                {
                    Console.WriteLine("That guess is lower than my number.");
                }
                else
                {
                    Console.WriteLine("That guess is higher than my number.");
                }
            }
        }
    }
}