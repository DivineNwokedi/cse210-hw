using System;

public class Entry
{
    public string _prompt { get; set; }
    public string _date { get; set; }
    public string _entryText { get; set; }
    public string _mood { get; set; }

    public Entry(string prompt, string date, string entryText, string mood)
    {
        _prompt = prompt;
        _date = date;
        _entryText = entryText;
        _mood = mood;
    }

    public void Display()
    {
        Console.WriteLine($"{_date} - {_prompt} - Mood: {_mood}");
        Console.WriteLine(_entryText);
    }
}

