using System;

public class Entry
{
    public string _prompt { get; set; }
    public string _date { get; set; }
    public string _entryText { get; set; }

    public Entry(string prompt, string date, string entryText)
    {
        _prompt = prompt;
        _date = date;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"{_date} - {_prompt}");
        Console.WriteLine(_entryText);
    }
}

