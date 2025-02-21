class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _targetCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _timesCompleted = 0;
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
    }

      public override int RecordEvent()
    {
        _timesCompleted++;
        if (_timesCompleted == _targetCount)
        {
            return _points + _bonusPoints;
        }
        return _points;
    }
    
    public override string GetDetailsString()
    {
        return ($"[{(_timesCompleted >= _targetCount ? "X" : " ")}] {_name} - {_description} (Completed {_timesCompleted}/{_targetCount})");
    }
    
    public override bool IsComplete() { return _timesCompleted >= _targetCount; }
}