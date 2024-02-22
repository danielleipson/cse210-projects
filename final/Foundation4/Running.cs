class Running : Activity
{
    public double Distance { get; set; }

    public Running(DateTime date, int lengthInMinutes, double distance)
        : base(date, lengthInMinutes)
    {
        Distance = distance;
    }

   
    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return Distance / (LengthInMinutes / 60.0); // Speed = miles per hour
    }

    public override double GetPace()
    {
        return LengthInMinutes / Distance; // Pace = minutes per mile
    }

    public override string GetSummary()
    {
        return $"{Date.ToShortDateString()} Running ({LengthInMinutes} min) - Distance: {Distance} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min/mile";
    }
}
