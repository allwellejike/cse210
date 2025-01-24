using System;
using System.Collections.Generic;
using System.IO.Compression;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int numberUsed = -1;
        while (numberUsed != 0)
        {
            Console.Write("Enter a number (0 to quit): ");

            string response = Console.ReadLine();
            numberUsed = int.Parse(response);

            if (numberUsed != 0)
            {
                numbers.Add(numberUsed);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {max = number;}
        }

        Console.WriteLine($"The max is: {max}");


    }

}