class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        User user = new User();

        // Create badges
        Badge badge1 = new Badge("Newbie", "Earn 100 points");
        Badge badge2 = new Badge("Pro", "Earn 1000 points");

        while (true)
        {
            Console.WriteLine("1. Create goal");
            Console.WriteLine("2. Record event");
            Console.WriteLine("3. Display goals");
            Console.WriteLine("4. Save goals");
            Console.WriteLine("5. Load goals");
            Console.WriteLine("6. Exit");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    goalManager.CreateGoal();
                    break;
                case 2:
                    goalManager.RecordEvent();
                    user.AddPoints(100); // Add points for completing a goal
                    if (user.Points >= 100 && !user.Badges.Any(b => b.Name == "Newbie"))
                    {
                        user.EarnBadge(badge1);
                    }
                    if (user.Points >= 1000 && !user.Badges.Any(b => b.Name == "Pro"))
                    {
                        user.EarnBadge(badge2);
                    }
                    break;
                case 3:
                    goalManager.DisplayGoals();
                    Console.WriteLine($"Points: {user.Points}");
                    Console.WriteLine($"Level: {user.Level}");
                    Console.WriteLine("Badges:");
                    foreach (var badge in user.Badges)
                    {
                        Console.WriteLine($"{badge.Name} - {badge.Description}");
                    }
                    break;
                case 4:
                    goalManager.SaveGoals();
                    break;
                case 5:
                    goalManager.LoadGoals();
                    break;
                case 6:
                    return;
                default:
                    throw new Exception("Invalid choice");
            }
        }
    }
}
