using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<double> numbers = new List<double>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // keep asking for numbers until they enter 0
        while (true)
        {
            Console.Write("Enter number: ");
            double input = double.Parse(Console.ReadLine());

            if (input == 0)
            {
                break;
            }

            numbers.Add(input);
        }

        // sum
        double sum = 0;
        foreach (double n in numbers)
        {
            sum = sum + n;
        }
        Console.WriteLine("The sum is: " + sum);

        // average
        double average = sum / numbers.Count;
        Console.WriteLine("The average is: " + average);

        // largest number
        double max = numbers[0];
        foreach (double n in numbers)
        {
            if (n > max)
            {
                max = n;
            }
        }
        Console.WriteLine("The largest number is: " + max);

        // stretch challenge 1 - smallest positive number
        double smallestPositive = double.MaxValue;
        foreach (double n in numbers)
        {
            if (n > 0 && n < smallestPositive)
            {
                smallestPositive = n;
            }
        }
        Console.WriteLine("The smallest positive number is: " + smallestPositive);

        //stretc
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (double n in numbers)
        {
            Console.WriteLine(n);
        }
    }
}