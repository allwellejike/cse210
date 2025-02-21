using System;
using System.Collections.Generic;
using System.IO;

class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);