using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int squared, int birthYear)
    {
        Console.WriteLine(name + ", the square of your number is " + squared);

        int age = 2025 - birthYear;
        Console.WriteLine(name + ", you will turn " + age + " this year.");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();
        int number = PromptUserNumber();

        int birthYear;
        PromptUserBirthYear(out birthYear);

        int squared = SquareNumber(number);

        DisplayResult(name, squared, birthYear);
    }
}