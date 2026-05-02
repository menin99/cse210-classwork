using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int number = rnd.Next(1, 101);
        Console.WriteLine("A random number has been generated from 1 to 100.\nIt is your job to guess it\nWhat is your guess?");
        int guess = int.Parse(Console.ReadLine());
        while (guess != number)
        {
            if (guess < number)
            {
                Console.WriteLine("Higher");
            } else
            {
                Console.WriteLine("Lower");
            }
            Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Good Job, You Guessed It.");
    }
}