public class Running : Activity
{
    public double DistanceInKilometers { get; set; }

    public Running(DateTime date, int lengthInMinutes, double distanceInKilometers) : base(date, lengthInMinutes)
    {
        DistanceInKilometers = distanceInKilometers;
    }

    public override double GetDistance()
    {
        return DistanceInKilometers;
    }

    public override double GetSpeed()
    {
        return (DistanceInKilometers / LengthInMinutes) * 60;
    }

    public override double GetPace()
    {
        return LengthInMinutes / DistanceInKilometers;
    }
}
