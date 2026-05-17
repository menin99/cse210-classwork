using System;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public string _filePath = "";

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void Save(string filename)
    {
        _filePath = filename;

        List<string> lines = new List<string>();

        foreach (Entry entry in _entries)
        {
            lines.Add($"{entry._date}|{entry._prompt}|{entry._response}|{entry._mood}");
        }

        File.WriteAllLines(_filePath, lines);

        Console.WriteLine("Journal saved successfully.");
    }

    public void Load(string filename)
    {
        _filePath = filename;
        _entries = new List<Entry>();

        string[] lines = File.ReadAllLines(_filePath);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._response = parts[2];
            entry._mood = parts[3];

            _entries.Add(entry);
        }

        Console.WriteLine("Journal loaded successfully.");
    }
}