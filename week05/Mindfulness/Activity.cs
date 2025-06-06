using System;

public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Start()
    {
        Console.WriteLine($"Welcome to the {_name} activity.");
        Console.WriteLine(_description);
        Console.Write("How long would you like to spend on this activity in seconds? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(5);
    }

    public void End()
    {
        Console.WriteLine("You have done a great job!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
        ShowSpinner(5);
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            System.Threading.Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("-");
            System.Threading.Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("\\");
            System.Threading.Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("|");
            System.Threading.Thread.Sleep(250);
            Console.Write("\b");
        }
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            System.Threading.Thread.Sleep(1000);
            Console.Write("\b\b");
        }
    }

    public int Duration
    {
        get { return _duration; }
    }

    public abstract void Run();
}
