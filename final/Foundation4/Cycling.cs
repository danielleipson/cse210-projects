class Cycling : Activity
{
    public double Speed { get; set; }

    public Cycling(DateTime date, int lengthInMinutes, double speed)
        : base(date, lengthInMinutes)
    {
        Speed = speed;
    }

    public override double GetDistance()
    {
        return Speed * (LengthInMinutes / 60.0); // Distance = miles
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
        return 60.0 / Speed; // Pace = minutes per mile
    }

    public override string GetSummary()
    {
        return $"{Date.ToShortDateString()} Cycling ({LengthInMinutes} min) - Distance: {GetDistance()} miles, Speed: {Speed} mph, Pace: {GetPace()} min/mile";
    }
}
