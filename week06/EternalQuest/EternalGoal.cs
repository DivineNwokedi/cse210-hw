public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points)
    {
    }

    public override void RecordEvent()
    {
        // No completion status change, just add points
    }
}
