using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 100);
        int number = -1;

        while (number != randomNumber)
        {
            Console.Write("Please guess a number. ");
            number = int.Parse(Console.ReadLine());

            if (number > randomNumber)
                Console.WriteLine("Lower!");
                
            else if (number < randomNumber)
                Console.WriteLine("Higher!");
            else
                Console.WriteLine("Congrats you guessed the number!");
        }
    }
}