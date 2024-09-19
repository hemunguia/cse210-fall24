using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("What is your grade percentage?");
        string gradeString = Console.ReadLine();
        int grade = int.Parse(gradeString);
        string letter;
        string passOrNot;

        if (grade >= 90 )
        {
            letter ="A";
        }
        else if (grade >= 80)
        {
            letter ="B";
        }
          else if (grade >= 70)
        {
            letter ="C";
        }
          else if (grade >= 60)
        {
            letter ="D";
        }
        else 
        {
            letter ="F";
        }

        
        if (! (letter =="A" || letter == "F"))
        {   
            int oneDigit = grade % 10;
            if(oneDigit>=7)
            {   
                letter += '+';
            }
            else
            {
                letter += '-';
            }

        }

        if (grade>=70)
        {
            passOrNot= "Congratulations you Pass with " + letter;
        }
        else
        {
            passOrNot= "Do a better effort next time you got " + letter;
        }

        Console.WriteLine(passOrNot);
    }
}