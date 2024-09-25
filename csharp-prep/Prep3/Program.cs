using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string response;
        do
        {
            Random randomGenerator = new();
            int number = randomGenerator.Next(1, 100);
            int magicN;
            do
            {
                Console.WriteLine("What is the magic number?");
                string magicNumber = Console.ReadLine();
                magicN = int.Parse(magicNumber);

                if (magicN > number) 
                {
                    Console.WriteLine("Lower");
                }
                else if (magicN < number) 
                {
                    Console.WriteLine("Higher");
                }
            }
             while (magicN != number);
            
            Console.WriteLine("You guessed it!");
            
            Console.WriteLine("Do you want to continue? ");
            response = Console.ReadLine();


        } 
        while (response == "yes");
        
    }
}