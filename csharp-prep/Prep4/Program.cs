using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of integers, type 0 when finished.");
        string finished = "no";
        List<int> numbers = new List<int>();
        while (finished == "no")
        {
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);
            if (userNumber == 0)
            {
                finished = "yes";
            }
            else
            {
                numbers.Add(userNumber);
            }
        }
        int listSum = 0;
        int listMax = numbers[0];
        for (int i=0; i<numbers.Count; i++)
        {
            listSum += numbers[i];
            if (numbers[i] > listMax)
            {
                listMax = numbers[i];
            }
        }
        float average = listSum/(numbers.Count);
        Console.WriteLine($"The sum is: {listSum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The maximum is {listMax}");
    }
}