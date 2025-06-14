

using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    public List<Goal> Goals { get; set; }
    public int TotalScore { get; set; }

    public GoalManager()
    {
        Goals = new List<Goal>();
        TotalScore = 0;
    }

    public void CreateGoal()
    {
        // Prompt user for goal type and details
        Console.WriteLine("Enter goal type (1 for simple, 2 for eternal, 3 for checklist):");
        int goalType = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter goal name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter goal points:");
        int points = int.Parse(Console.ReadLine());

        Goal goal;
        switch (goalType)
        {
            case 1:
                goal = new SimpleGoal(name, points);
                break;
            case 2:
                goal = new EternalGoal(name, points);
                break;
            case 3:
                Console.WriteLine("Enter required completions:");
                int requiredCompletions = int.Parse(Console.ReadLine());
                goal = new ChecklistGoal(name, points, requiredCompletions);
                break;
            default:
                throw new Exception("Invalid goal type");
        }

        Goals.Add(goal);
    }

    public void RecordEvent()
    {
        // Prompt user for goal to record
        Console.WriteLine("Enter goal index:");
        int goalIndex = int.Parse(Console.ReadLine());
        Goals[goalIndex].RecordEvent();
        TotalScore += Goals[goalIndex].Points;
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < Goals.Count; i++)
        {
            Console.WriteLine($"{i}: {Goals[i].GetDetailsString()}");
        }
        Console.WriteLine($"Total Score: {TotalScore}");
    }

    public void SaveGoals()
    {
        using (StreamWriter outputFile = new StreamWriter("goals.txt"))
        {
            outputFile.WriteLine(TotalScore);
            foreach (Goal goal in Goals)
            {
                outputFile.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.Points},{goal.IsComplete}");
                if (goal is ChecklistGoal checklistGoal)
                {
                    outputFile.WriteLine($"{checklistGoal.CurrentCompletions},{checklistGoal.RequiredCompletions}");
                }
            }
        }
    }

    public void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            string[] lines = File.ReadAllLines("goals.txt");
            TotalScore = int.Parse(lines[0]);
            Goals.Clear();
            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');
                Goal goal;
                switch (parts[0])
                {
                    case "SimpleGoal":
                        goal = new SimpleGoal(parts[1], int.Parse(parts[2]));
                        break;
                    case "EternalGoal":
                        goal = new EternalGoal(parts[1], int.Parse(parts[2]));
                        break;
                    case "ChecklistGoal":
                        goal = new ChecklistGoal(parts[1], int.Parse(parts[2]), int.Parse(lines[i + 1].Split(',')[1]));
                        ((ChecklistGoal)goal).CurrentCompletions = int.Parse(lines[i + 1].Split(',')[0]);
                        i++;
                        break;
                    default:
                        throw new Exception("Invalid goal type");
                }
                goal.IsComplete = bool.Parse(parts[3]);
                Goals.Add(goal);
            }
        }
    }
}
