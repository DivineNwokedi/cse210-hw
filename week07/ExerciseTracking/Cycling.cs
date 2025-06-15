public class Cycling : Activity
{
    public double AverageSpeedInKph { get; set; }

    public Cycling(DateTime date, int lengthInMinutes, double averageSpeedInKph) : base(date, lengthInMinutes)
    {
        AverageSpeedInKph = averageSpeedInKph;
    }

    public override double GetDistance()
    {
        return (AverageSpeedInKph / 60) * LengthInMinutes;
    }

    public override double GetSpeed()
    {
        return AverageSpeedInKph;
    }

    public override double GetPace()
    {
        return 60 / AverageSpeedInKph;
    }
}
