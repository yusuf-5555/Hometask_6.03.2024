public class Rectangle : Shape
{
    double _length;
    double _width;

    public Rectangle(double length, double width)
    {
        _length = length;
        _width = width;
    }
    public override double CalculateArea()
    {
       return _length*_width;
    }
    public override string PrintDescription()
    {
        return $"This is Rectangle";
    }
}