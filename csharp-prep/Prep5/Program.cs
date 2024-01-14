using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        displayWelcome();

        string name = promptUserName();
        int userNumber = promptUserNumber();

        int squared = squareNumber(userNumber);

        displayResult(name, userNumber, squared);

        static void displayWelcome()
        {
        Console.WriteLine("Welcome to the program!");
        }

        static string promptUserName()
        {
            Console.WriteLine("Please enter your first name: ");
            string userName = Console.ReadLine();

            return userName;
        }
    
        static int promptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number! ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int squareNumber(int number)
        {
            int squared = number * number;
            return squared;
        }
        
        static void displayResult(string userName, int number, int squared)
        {
            Console.WriteLine($"{userName} The square of your number {number} is {squared}.");
        }
    }
}