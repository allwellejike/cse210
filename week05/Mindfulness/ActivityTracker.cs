class ActivityTracker
{
    private static string logFile = "activity_log.txt";
    
    public static void LogActivity(string activityName, int duration)
    {
        File.AppendAllText(logFile, $"{DateTime.Now}: {activityName} - {duration} seconds\n");
    }

    public static void ShowLog()
    {
        if (File.Exists(logFile))
            Console.WriteLine(File.ReadAllText(logFile));
        else
            Console.WriteLine("No activities logged yet.");
    }
}
