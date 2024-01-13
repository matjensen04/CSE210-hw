using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade?");
        string number = Console.ReadLine();
        int grade = int.Parse(number);
        string letter = "";

        if (grade >= 93 )
            {
                letter = "A";
            }
        else if (grade < 93 && grade >= 90)
            {
                letter = "A-";
            }
        else if (grade >= 87)
            {
                letter = "B+";
            }
        else if (grade >= 83)
            {
                letter = "B";
            }
        else if (grade < 83 && grade >=80) 
            {
                letter = "B-";
            }
        else if (grade >= 77)
            {
                letter = "C+";
            }
        else if (grade >= 73)
            {
                letter = "C";
            }
        else if (grade < 73 && grade >= 70)
            {
                letter = "C-";
            }
        else if (grade >= 67)
            {
                letter = "D+";
            }
        else if (grade >= 63)
            {
                letter = "D";
            }
        else if (grade < 63 && grade >= 60)
            {
                letter = "D-";
            }
        else
            {
                letter = "F";
            }

        Console.WriteLine($"Your grade is a {letter}.");

        if (grade >= 70)
            {
                Console.WriteLine("You passed the class!");
            }
        else
        Console.WriteLine("You did not pass.");
    }
}