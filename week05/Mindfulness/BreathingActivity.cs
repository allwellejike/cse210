
class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity helps you relax by guiding your breathing.") { }

    protected override void Run()
    {
        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.Write("Breathe in... ");
            Countdown(4);
            Console.Write("Breathe out... ");
            Countdown(4);
            elapsed += 8;
        }
    }

    private void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
