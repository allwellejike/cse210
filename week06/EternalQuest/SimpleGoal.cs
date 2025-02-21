class SimpleGoal : Goal
{
    private bool _isComplete;
    
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

     public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }
    
    public override string GetDetailsString()
    {
        return ($"[{(_isComplete ? "X" : " ")}] {_name} - {_description}");
    }
    
    public override bool IsComplete() { return _isComplete; }
}