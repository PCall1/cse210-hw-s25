using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = [];

        Square square = new("red", 9);
        shapes.Add(square);
        Rectangle rectangle = new("blue", 5, 4);
        shapes.Add(rectangle);
        Circle circle = new("yellow", 3);
        shapes.Add(circle);

        for (int i = 0; i < shapes.Count(); i++)
        {
            double area = shapes[i].GetArea();
            string color = shapes[i].GetColor();
            Console.WriteLine($"{color}, {area}");
        }
    }
}