class Hiking : Activity
{
    public double Distance { get; set; }
    public double ElevationGain { get; set; }

    public Hiking(DateTime date, int lengthInMinutes, double distance, double elevationGain)
        : base(date, lengthInMinutes)
    {
        Distance = distance;
        ElevationGain = elevationGain;
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
    return $"{Date.ToShortDateString()} Hiking ({LengthInMinutes} min) - Distance: {Distance} miles, Elevation Gain: {ElevationGain} feet, Speed: {GetSpeed()} mph, Pace: {GetPace()} min/mile";
}
}
