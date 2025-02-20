class ListingActivity : Activity
{
    private List<string> _prompts = new() { "List people you appreciate.", "List your personal strengths.", "List things that make you happy." };
    
    public ListingActivity() : base("Listing Activity", "This activity helps you list positive things in your life.") { }
