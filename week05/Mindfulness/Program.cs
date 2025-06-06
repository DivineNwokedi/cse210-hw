// Exceeding requirements: Saving and loading progress
// Added feature to save the number of activities completed and the total duration
// This feature allows users to track their progress across multiple sessions

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int activitiesCompleted = LoadProgress();
        int totalDuration = LoadDuration();

        while (true)
        {
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            Console.Write("Choose an activity: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    activitiesCompleted++;
                    totalDuration += breathingActivity.Duration;
                    SaveProgress(activitiesCompleted);
                    SaveDuration(totalDuration);
                    break;
                case "2":
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.Run();
                    activitiesCompleted++;
                    totalDuration += reflectionActivity.Duration;
                    SaveProgress(activitiesCompleted);
                    SaveDuration(totalDuration);
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    activitiesCompleted++;
                    totalDuration += listingActivity.Duration;
                    SaveProgress(activitiesCompleted);
                    SaveDuration(totalDuration);
                    break;
                case "4":
                    Console.WriteLine($"You completed {activitiesCompleted} activities with a total duration of {totalDuration} seconds.");
                    return;
            }
        }
    }

    static int LoadProgress()
    {
        if (File.Exists("progress.txt"))
        {
            using (StreamReader reader = new StreamReader("progress.txt"))
            {
                return int.Parse(reader.ReadLine());
            }
        }
        else
        {
            return 0;
        }
    }

    static void SaveProgress(int activitiesCompleted)
    {
        using (StreamWriter writer = new StreamWriter("progress.txt"))
        {
            writer.WriteLine(activitiesCompleted);
        }
    }

    static int LoadDuration()
    {
        if (File.Exists("duration.txt"))
        {
            using (StreamReader reader = new StreamReader("duration.txt"))
            {
                return int.Parse(reader.ReadLine());
            }
        }
        else
        {
            return 0;
        }
    }

    static void SaveDuration(int totalDuration)
    {
        using (StreamWriter writer = new StreamWriter("duration.txt"))
        {
            writer.WriteLine(totalDuration);
        }
    }
}


