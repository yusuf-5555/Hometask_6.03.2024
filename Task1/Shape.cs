public abstract class Shape
{
    public abstract double CalculateArea();
    public virtual string PrintDescription()
    {
        return $"This shape is triangle";
    }
}