using System;
using System.Collections.Generic;

class ListingActivity : Activity
{
    private List<string> _promptList;
    private int _itemCount;

    public ListingActivity() : base(
        "Listing",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _promptList = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        _itemCount = 0;
    }

    public void StartActivity()
    {
        DisplayStartMessage();
        WritePrompt();
        LoopResponse();
        Console.WriteLine($"\nYou listed {_itemCount} items!");
        ShowSpinner(3);
        DisplayEndMessage();
    }

    public void WritePrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"\n{prompt}");
        Console.WriteLine("\nYou have a few seconds to think of your first item...");
        ShowSpinner(5);
        Console.WriteLine("\nStart listing items (press enter after each):");
    }

    public void LoopResponse()
    {
        _itemCount = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _itemCount++;
        }
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return _promptList[rand.Next(_promptList.Count)];
    }
}