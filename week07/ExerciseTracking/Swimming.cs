class Swimming : Activity
{
    private int _laps;
    private const double LapDistance = 50.0 / 1000; // 50m per lap converted to km
    
    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }
    
    public override double GetDistance() => _laps * LapDistance;
    public override double GetSpeed() => (GetDistance() / GetMinutes()) * 60;
    public override double GetPace() => GetMinutes() / GetDistance();
}