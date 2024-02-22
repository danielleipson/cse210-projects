class Swimming : Activity
{
    public int Laps { get; set; }

    public Swimming(DateTime date, int lengthInMinutes, int laps)
        : base(date, lengthInMinutes)
    {
        Laps = laps;
    }

  
    public override double GetDistance()
    {
        return Laps * 50.0 / 1000; // Distance = kilometers
    }

    public override double GetSpeed()
    {
        return GetDistance() / (LengthInMinutes / 60.0); // Speed = kilometers per hour
    }

    public override double GetPace()
    {
        return LengthInMinutes / GetDistance(); // Pace = minutes per kilometer
    }

    public override string GetSummary()
    {
        return $"{Date.ToShortDateString()} Swimming ({LengthInMinutes} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min/km";
    }
}
