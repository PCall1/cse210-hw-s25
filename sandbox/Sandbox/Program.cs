using System;
/*
class Program

{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
    }
}
*/
class program 
{
    static void Main(string[] args)
    {
int x = 3;
int y = 5;
int value = 4;
string s = "Hello World!";
int z = x + y;
float f = 3.14f;
double g = 5.8989; //no + to 'double'
bool b = false; //also ^
string h = $"Hello {z+f+s+value} {g} {b} World!";

        //compute area of circle

        //get radius from user
        Console.Write("Enter radius of circle: ");
        string radius = Console.ReadLine();
        double r = double.Parse(radius);
        //compute area of circle
        double area = Math.PI * r * r;
        //display area of circle
        Console.WriteLine($"Area of circle with radius {r} is {area}");



    }


}