using System;
using System.IO.Compression;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());

        int guessNumber = -1;

        while (guessNumber != magicNumber)
        {
            Console.Write("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());

            if (magicNumber > guessNumber)
            {
                Console.WriteLine("Higher");
            }

            else if (magicNumber < guessNumber)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("You guessed it");
            }


        }
            
        }
         
    }
