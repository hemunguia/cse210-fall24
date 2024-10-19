using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction fraction = new Fraction();
        Console.WriteLine(fraction.GetFractionstring());
        Console.WriteLine(fraction.GetDecimalValue());
        
        Fraction fraction1 = new Fraction(5);
        Console.WriteLine(fraction1.GetFractionstring());
        Console.WriteLine(fraction1.GetDecimalValue());
        
        Fraction fraction2 = new Fraction(3,4);
        Console.WriteLine(fraction2.GetFractionstring());
        Console.WriteLine(fraction2.GetDecimalValue());

        Fraction fraction3 = new Fraction(1,3);
        Console.WriteLine(fraction3.GetFractionstring());
        Console.WriteLine(fraction3.GetDecimalValue());
       


    }
}