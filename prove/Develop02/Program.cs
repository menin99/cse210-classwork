using System;

//This program exceeds by asking the user to give their mood level out of 10 after they write an entry
//The mood is saved and then displayed alongside the journal entry.
//This will make it easier to compare your mood level day from day just at a glance.

class Program
{
    static Journal _journal = new Journal();
    static PromptGeneration _promptGenerator = new PromptGeneration();
    static void Main(string[] args)
    {
        _promptGenerator.SetupPrompts();
        Run();
    }
    static void Run()
    {
        bool running = true;
        while (running)
        {
            DisplayMenu();
            string choice = Console.ReadLine();
 
            if (choice == "1")
            {
                WriteEntry();
            }
            else if (choice == "2")
            {
                _journal.DisplayEntries();
            }
            else if (choice == "3")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                _journal.Save(filename);
            }
            else if (choice == "4")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                _journal.Load(filename);
            }
            else if (choice == "5")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("That is not a valid choice. Please try again.");
            }
        }
    }
    static void DisplayMenu()
    {
        Console.WriteLine("\nPlease select one of the following choices:");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the journal to a file");
        Console.WriteLine("4. Load the journal from a file");
        Console.WriteLine("5. Quit");
        Console.Write("> ");
    }
    static void WriteEntry()
    {
        string prompt = _promptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.Write("> ");
        string response = Console.ReadLine();
 
        Console.Write("How would you rate your mood today? (1-10): ");
        string mood = Console.ReadLine();
 
        Entry entry = new Entry();
        entry._date = DateTime.Now.ToShortDateString();
        entry._prompt = prompt;
        entry._response = response;
        entry._mood = mood;
        _journal.AddEntry(entry);
    }
}
 