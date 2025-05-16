
using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries { get; set; }

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void WriteToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry._date} | {entry._prompt}");
                writer.WriteLine($"Mood: {entry._mood}");
                writer.WriteLine(entry._entryText);
                writer.WriteLine();
            }
        }
    }

    public void ReadFromFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        string date = "";
        string prompt = "";
        string entryText = "";
        string mood = "";

        foreach (var line in lines)
        {
            if (line.Contains("|"))
            {
                string[] parts = line.Split(new string[] { " | " }, StringSplitOptions.None);
                date = parts[0];
                prompt = parts[1];
            }
            else if (line.StartsWith("Mood:"))
            {
                mood = line.Split(new string[] { ": " }, StringSplitOptions.None)[1];
            }
            else if (line == "")
            {
                if (!string.IsNullOrEmpty(entryText))
                {
                    Entry entry = new Entry(prompt, date, entryText, mood);
                    AddEntry(entry);
                    entryText = "";
                    mood = "";
                }
            }
            else
            {
                entryText += line + "\n";
            }
        }

        // Add the last entry
        if (!string.IsNullOrEmpty(entryText))
        {
            Entry entry = new Entry(prompt, date, entryText.Trim(), mood);
            AddEntry(entry);
        }
    }
}
