class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Show Log");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            Activity activity = choice switch
            {
                "1" => new BreathingActivity(),
                "2" => new ReflectingActivity(),
                "3" => new ListingActivity(),
                "4" => null,
                _ => null
            };

            if (choice == "5") break;
            if (choice == "4") { ActivityTracker.ShowLog(); Console.ReadLine(); continue; }
            activity?.Start();
        }
    }
}
