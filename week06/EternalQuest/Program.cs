using System;

class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            
            int choice = int.Parse(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    Console.Write("Enter Goal Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Description: ");
                    string description = Console.ReadLine();
                    Console.Write("Enter Points: ");
                    int points = int.Parse(Console.ReadLine());
                    Console.Write("Goal Type (1-Simple, 2-Eternal, 3-Checklist): ");
                    int type = int.Parse(Console.ReadLine());
                    
                    if (type == 1)
                        manager.AddGoal(new SimpleGoal(name, description, points));
                    else if (type == 2)
                        manager.AddGoal(new EternalGoal(name, description, points));
                    else if (type == 3)
                    {
                        Console.Write("Target Count: ");
                        int target = int.Parse(Console.ReadLine());
                        Console.Write("Bonus Points: ");
                        int bonus = int.Parse(Console.ReadLine());
                        manager.AddGoal(new ChecklistGoal(name, description, points, target, bonus));
                    }
                    break;
                case 2:
                    manager.DisplayGoals();
                    break;
                case 3:
                    Console.Write("Enter Goal Number: ");
                    int num = int.Parse(Console.ReadLine()) - 1;
                    manager.RecordEvent(num);
                    break;
                case 4:
                    manager.SaveGoals();
                    break;
                case 5:
                    manager.LoadGoals();
                    break;
                case 6:
                    running = false;
                    break;
            }
        }
    }
}

        