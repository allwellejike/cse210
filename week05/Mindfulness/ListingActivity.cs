class ListingActivity : Activity
{
    private List<string> _prompts = new() { "List people you appreciate.", "List your personal strengths.", "List things that make you happy." };
    
    public ListingActivity() : base("Listing Activity", "This activity helps you list positive things in your life.") { }

      protected override void Run()
    {
        Random rnd = new();
        string prompt = _prompts[rnd.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        ShowSpinner(3);
        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item: ");
            Console.ReadLine();
            count++;
        }
        Console.WriteLine($"You listed {count} items.");
    }
}
