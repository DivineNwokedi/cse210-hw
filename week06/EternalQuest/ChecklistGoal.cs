public class ChecklistGoal : Goal
{
    public int RequiredCompletions { get; set; }
    public int CurrentCompletions { get; set; }

    public ChecklistGoal(string name, int points, int requiredCompletions) : base(name, points)
    {
        RequiredCompletions = requiredCompletions;
        CurrentCompletions = 0;
    }

    public override void RecordEvent()
    {
        CurrentCompletions++;
        if (CurrentCompletions >= RequiredCompletions)
        {
            IsComplete = true;
        }
    }
}
