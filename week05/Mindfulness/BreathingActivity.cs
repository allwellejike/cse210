
class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity helps you relax by guiding your breathing.") { }

    protected override void Run()
    {
        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.WriteLine("Breathe in...");
            Countdown(4);
            Console.WriteLine("Breathe out...");
            Countdown(4);
            elapsed += 8;
        }
    }

    private void Countdown(int v)
    {
        throw new NotImplementedException();
    }
}