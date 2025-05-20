using System.Diagnostics;

public class Fraction
{

    
    private int _top = 1;
    private int _bottom = 1;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }


    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }
    public double GetFractionDecimal()
    { 
        return (double)_top / _bottom;
    }



}