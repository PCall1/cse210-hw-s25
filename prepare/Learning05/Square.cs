using System.Drawing;
using System.Reflection.Metadata.Ecma335;

class Square : Shape
{
    public double _side { get; set; }
    public Square(string color, double side) :
    base(color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}