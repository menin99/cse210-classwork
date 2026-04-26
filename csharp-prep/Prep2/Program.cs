using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What percent did you get as a grade?");
        int gradePercent = int.Parse(Console.ReadLine());
        string letter = "";
        if (gradePercent >= 90) {
            letter = "A";
        }
        else if (gradePercent >= 80) {
            letter = "B";
        }
        else if (gradePercent >= 70) {
            letter = "C";
        }
        else if (gradePercent >= 60) {
            letter = "D";
        }
        else {
            letter = "F";
        }
        Console.WriteLine("Your letter grade is " + letter + ".");
        if (gradePercent >= 70)
        {
            Console.WriteLine("You passed.");
        } else
        {
            Console.WriteLine("You did not pass.");
        }
    }
}