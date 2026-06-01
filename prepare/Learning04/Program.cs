using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("John Doe", "Multiplication");
        Console.WriteLine(a1.GetSummary());
        MathAssignment a2 = new MathAssignment("Arthur Smith", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());
        WritingAssignment a3 = new WritingAssignment("Jane Doe", "World History", "The Industrial Revolution");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());

    }
}