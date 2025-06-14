public abstract class Goal
{
    public string Name { get; set; }
    public int Points { get; set; }
    public bool IsComplete { get; set; }

    public Goal(string name, int points)
    {
        Name = name;
        Points = points;
        IsComplete = false;
    }

    public virtual void RecordEvent()
    {
        // To be overridden by derived classes
    }

    public virtual string GetDetailsString()
    {
        return $"[{(!IsComplete ? " " : "X")}] {Name}";
    }
}



