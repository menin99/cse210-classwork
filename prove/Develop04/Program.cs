using System;
using System.Collections.Generic;

class Program
{
    private List<string> _activityList;
    private List<Activity> _activities;

    public Program()
    {
        _activityList = new List<string>
        {
            "Breathing Activity",
            "Reflecting Activity",
            "Listing Activity"
        };
        _activities = new List<Activity>();
    }

    public void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Start Breathing Activity");
        Console.WriteLine("  2. Start Reflecting Activity");
        Console.WriteLine("  3. Start Listing Activity");
        Console.WriteLine("  4. View Activity Log");
        Console.WriteLine("  5. Quit");
        Console.Write("\nSelect a choice from the menu: ");
    }

    public void RunMenu()
    {
        string choice = "";
        while (choice != "5")
        {
            DisplayMenu();
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.StartActivity();
                _activities.Add(activity);
            }
            else if (choice == "2")
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.StartActivity();
                _activities.Add(activity);
            }
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.StartActivity();
                _activities.Add(activity);
            }
            else if (choice == "4")
            {
                ShowActivityLog();
            }
        }
    }

    public void ShowActivityLog()
    {
        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;

        foreach (Activity a in _activities)
        {
            if (a is BreathingActivity)
                breathingCount++;
            else if (a is ReflectingActivity)
                reflectingCount++;
            else if (a is ListingActivity)
                listingCount++;
        }

        Console.Clear();
        Console.WriteLine("Activity Log");
        Console.WriteLine("------------");
        Console.WriteLine($"  Breathing:  {breathingCount} time(s)");
        Console.WriteLine($"  Reflecting: {reflectingCount} time(s)");
        Console.WriteLine($"  Listing:    {listingCount} time(s)");
        Console.WriteLine($"  Total:      {_activities.Count} time(s)");
        Console.Write("\nPress enter to return to the menu...");
        Console.ReadLine();
    }

    static void Main(string[] args)
    {
        Program program = new Program();
        program.RunMenu();
    }
}