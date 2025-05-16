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

        foreach (var line in lines)
        {
            if (line.Contains("|"))
            {
                string[] parts = line.Split(new string[] { " | " }, StringSplitOptions.None);
                date = parts[0];
                prompt = parts[1];
            }
            else if (line == "")
            {
                if (!string.IsNullOrEmpty(entryText))
                {
                    Entry entry = new Entry(prompt, date, entryText);
                    AddEntry(entry);
                    entryText = "";
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
            Entry entry = new Entry(prompt, date, entryText.Trim());
            AddEntry(entry);
        }
    }
}


