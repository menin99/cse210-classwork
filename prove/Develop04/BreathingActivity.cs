using System;
using System.Threading;

class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void StartActivity()
    {
        DisplayStartMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            BreathCycle();
        }

        DisplayEndMessage();
    }

    public void BreathCycle()
    {
        Console.Write("\nBreathe in...");
        ShowCountdown(4);
        Console.Write("Breathe out...");
        ShowCountdown(6);
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            string text = i.ToString();
            Console.Write(text);
            Thread.Sleep(1000);
            for (int j = 0; j < text.Length; j++)
            {
                Console.Write("\b \b");
            }
        }
        Console.WriteLine();
    }
}