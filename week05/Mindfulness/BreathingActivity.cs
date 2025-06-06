using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    public override void Run()
    {
        Start();
        for (int i = 0; i < _duration; i += 8)
        {
            Console.WriteLine("Breathe in...");
            base.ShowCountdown(4);
            Console.WriteLine("Breathe out...");
            base.ShowCountdown(4);
        }
        End();
    }
}
