class Circle : Shape
{
    public double _radius { get; set; }
    public Circle(string color, double radius) :
    base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}