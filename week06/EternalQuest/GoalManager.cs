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
    }

      
    public void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i+1}. {_goals[i].GetDetailsString()}");
        }
        Console.WriteLine($"Total Score: {_score}");
    }
