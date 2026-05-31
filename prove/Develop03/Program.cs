using System;
using System.Collections.Generic;
using System.Linq;

//I exceeded requirements by creating a list of scriptures to use as a library that the program randomly chooses from by generating a random positive integer. 
class Program
{
    static void Main(string[] args)
    {
        List<Scripture> library = new List<Scripture>
        {
            new Scripture (
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life"
            ),
            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding In all thy ways acknowledge him and he shall direct thy paths"
            ),
            new Scripture(
                new Reference("Philippians", 4, 13),
                "I can do all things through Christ which strengtheneth me"
            ),
            new Scripture(
                new Reference("Joshua", 1, 9),
                "Be strong and of a good courage be not afraid neither be thou dismayed for the Lord thy God is with thee whithersoever thou goest"
            ),
            new Scripture(
                new Reference("Isaiah", 41, 10),
                "Fear thou not for I am with thee be not dismayed for I am thy God I will strengthen thee yea I will help thee"
            )
        };

        Random rand = new Random();
        Scripture scripture = library[rand.Next(library.Count)];
        while (true)
        {
            Console.Clear();
            scripture.Display();
            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("\nAll of the words have been hidden, good job.");
                Console.WriteLine("Press Enter to Exit");
                Console.ReadLine();
                break;
            }
            Console.WriteLine("\nPress Enter to hide random words or type \"quit\" to exit:");
            string input = Console.ReadLine().Trim().ToLower();
            if (input == "quit")
            {
                Console.WriteLine("\nGood practice, come back soon.");
                break;
            }
            scripture.HideRandomWords();
        }
    }
}