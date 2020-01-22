using System;

namespace Lab3DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            
            Console.Write($"Hi {userName}!\nEnter a number between 1 and 100: ");
            int userInput = int.Parse(Console.ReadLine());


            if (userInput % 2 != 0)
            {
                Console.WriteLine($"{userInput} is Odd.");
            }
            else if ((userInput % 2 == 0) && (userInput <= 25))
            {
                Console.WriteLine("Even and less than 25.");
            }
            else if ((userInput % 2 == 0) && (userInput <= 60))
            {
                Console.WriteLine("Even");
            }
            else if ((userInput%2 == 0) && (userInput > 60))
            {
                Console.WriteLine($"{userInput} is even.");
            }
            else if ((userInput % 2 != 0) && (userInput >= 60))
            {
                Console.WriteLine($"{userInput} is odd.");
            }


            Console.WriteLine($"\nThank you for entering your numbers, {userName}!  The end.");
            Console.ReadKey();
        }

        

    }
}
