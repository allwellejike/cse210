class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) {}
    
    public override int RecordEvent()
    {
        return _points;
    }

      public override string GetDetailsString()
    {
        return ($"[∞] {_name} - {_description}");
    }
}