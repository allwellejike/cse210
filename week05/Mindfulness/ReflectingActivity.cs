class ReflectingActivity : Activity
{
    private List<string> _prompts = new() { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need." };
    private List<string> _questions = new() { "Why was this experience meaningful?", "How did you feel when it was complete?", "What did you learn about yourself?" };

    public ReflectingActivity() : base("Reflection Activity", "This activity helps you reflect on moments of strength.") { }
