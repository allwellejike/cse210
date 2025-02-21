class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(DateTime.Now, 30, 4.8),
            new Cycling(DateTime.Now, 45, 20.0),
            new Swimming(DateTime.Now, 20, 40)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}