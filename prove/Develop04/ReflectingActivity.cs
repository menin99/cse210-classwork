using System;
using System.Collections.Generic;

class ReflectingActivity : Activity
{
    private List<string> _promptList;
    private List<string> _questionList;

    public ReflectingActivity() : base(
        "Reflecting",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _promptList = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questionList = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void StartActivity()
    {
        DisplayStartMessage();
        PromptAndWait();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            QuestionMethod();
        }

        DisplayEndMessage();
    }

    public void PromptAndWait()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"\n{prompt}");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You have several seconds to reflect on each question.");
        ShowSpinner(5);
    }

    public void QuestionMethod()
    {
        Random rand = new Random();
        string question = _questionList[rand.Next(_questionList.Count)];
        Console.Write($"\n> {question} ");
        ShowSpinner(5);
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return _promptList[rand.Next(_promptList.Count)];
    }
}