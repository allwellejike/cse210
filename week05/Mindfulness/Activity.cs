using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

     public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Starting {_name}\n{_description}");
        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
        Run();
        End();
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

     protected abstract void Run();

    // End the activity and log completion
    protected void End()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You completed {_name} for {_duration} seconds.");
        ShowSpinner(3);
        ActivityTracker.LogActivity(_name, _duration);
    }
}

