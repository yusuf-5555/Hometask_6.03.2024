public class Car : IMovable
{
    string _color;
    double _speed;
    string _model;
    public Car(string color, double speed, string model)
    {
        _color = color;
        _model = model;
        _speed = speed;
    }

    public void MoveLeft()
    {
        System.Console.WriteLine("The car move to left");
    }

    public void MoveRight()
    {
        System.Console.WriteLine("The car move to right");
    }
}