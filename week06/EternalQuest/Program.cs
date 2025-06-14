// Exceeding Requirements:
// I added a leveling system and badges to make the program more engaging.
// Users can level up and earn badges as they complete goals and earn points.

public class User
{
    public int Points { get; set; }
    public int Level { get; set; }
    public List<Badge> Badges { get; set; }

    public User()
    {
        Points = 0;
        Level = 1;
        Badges = new List<Badge>();
    }

    public void AddPoints(int points)
    {
        Points += points;
        CheckForLevelUp();
    }

    private void CheckForLevelUp()
    {
        if (Points >= Level * 1000)
        {
            LevelUp();
        }
    }

    private void LevelUp()
    {
        Level++;
        Console.WriteLine($"Congratulations, you've leveled up to level {Level}!");
    }

    public void EarnBadge(Badge badge)
    {
        Badges.Add(badge);
        Console.WriteLine($"Congratulations, you've earned the {badge.Name} badge!");
    }
}

public class Badge
{
    public string Name { get; set; }
    public string Description { get; set; }

    public Badge(string name, string description)
    {
        Name = name;
        Description = description;
    }
}

