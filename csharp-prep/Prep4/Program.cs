using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
     
          int number = 1;
          List<int> numberList = new List<int>();
          Console.WriteLine("Enter a list of numbers, type 0 when finished.");

          do {
            Console.WriteLine("Enter Number: ") ;
              string numberS = Console.ReadLine();
              number = int.Parse(numberS);
               if (number != 0)
            {
              numberList.Add(number);
            }
          } while (number != 0);

          int sumNumbers = 0;
   
          foreach (int num in numberList)
          {
                sumNumbers += num;
          }

        Console.WriteLine($"The sum is: {sumNumbers}");

 
        float numberAvg = 0;
        numberAvg = (float)sumNumbers / numberList.Count;
        Console.WriteLine($"The average is: {numberAvg}");

        int largest = numberList.Max();
        Console.WriteLine($"The largest is: {largest}");

        Console.WriteLine("The sorted list is:");

        numberList.Sort();
          foreach (int num in numberList)
          {
               Console.WriteLine(num);
          }







    }

}