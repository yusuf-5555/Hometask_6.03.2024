public class Circle : Shape
{
    double _radius;
    const double n = 3.14;

    public Circle(double radius)
    {
        _radius = radius;
    }
    public override double CalculateArea()
    {
        return n*_radius*_radius;
    }
    public override string PrintDescription()
    {
        return $"This is Circle";
    }
}