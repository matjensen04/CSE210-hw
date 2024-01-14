using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please add your numbers. Type 0 to end the program.");
        int end = 1;
        List<int> listNum = new List<int>();
        int add = 0;
        int largest = 0;

        while (end != 0)
        {
            string userNumbers = Console.ReadLine();
            end = int.Parse(userNumbers);

            if (end != 0)
            {
                listNum.Add(end);
            }
        }

        foreach (int number in listNum)
        {
            add += number;
        }
        Console.WriteLine($"The sum of the list is: {add}");

        float average = (((float)add) / listNum.Count);
        Console.WriteLine($"The average of the list is: {average}");

        foreach (int number in listNum)
        {
            if (number > largest)
            {
                largest = number;
            }
        }

        Console.WriteLine($"The largest number is {largest}");
    }
}