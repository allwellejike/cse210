using System;

public class Program
{
    public static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("\nJournal Menu");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save journal to a file");
            Console.WriteLine("4. Load journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"\nPrompt: {prompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine();
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                journal.AddEntry(new Entry(date, prompt, response));
                Console.WriteLine("Entry added successfully.");
            }
            else if (choice == "2")
            {
                Console.WriteLine("\nJournal Entries:");
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter file name to save journal: ");
                string saveFileName = Console.ReadLine();
                journal.SaveToFile(saveFileName);
            }
            else if (choice == "4")
            {
                Console.Write("Enter file name to load journal: ");
                string loadFileName = Console.ReadLine();
                journal.LoadFromFile(loadFileName);
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
                break; // Exits the loop
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        

        }

    }
}