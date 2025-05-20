using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the Numerator: ");
        int top = int.Parse(Console.ReadLine());
        Console.Write("Enter the Denominator: ");
        int bottom = int.Parse(Console.ReadLine());


        Console.WriteLine("Your fraction is: ");
        Fraction fraction1 = new(top, bottom);
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetFractionDecimal());

        Console.WriteLine("Numerator only: ");
        Fraction fraction2 = new(top);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetFractionDecimal());

        Console.WriteLine("Default fraction (no input): ");
        Fraction fraction3 = new();
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetFractionDecimal());

        /*
        Console.WriteLine("Inverse fraction: ");
        Fraction fraction4 = new Fraction(bottom, top);
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetFractionDecimal()); 
        */
    }
}