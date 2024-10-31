using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        
        Console.WriteLine("New Assignment");
        Assignment assignment = new Assignment("Herbert Munguia", "Inheritance and beyond");
        Console.WriteLine(assignment.GetSummary());
        
        Console.WriteLine("New Math Assignment");
        MathAssignment mathassignment = new MathAssignment("Enrique Canales", "Fractions", "Section 7.3", "8-19");
        Console.WriteLine(mathassignment.GetSummary());
        Console.WriteLine(mathassignment.GetHomeWorkList());

        Console.WriteLine("New Writing Assignment");
        WritingAssignment writingassignment = new WritingAssignment("Herbert Munguia", "European History", "The Causes of World War II");
        Console.WriteLine(writingassignment.GetSummary());
        Console.WriteLine(writingassignment.GetWritingInformation());
        






       

        
    }
}