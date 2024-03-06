public class Bus : IMovable
{
    string _color;
    double _speed;
    string _model;

    public Bus(string color, double speed, string model)
    {
        _color = color;
        _model = model;
        _speed = speed;
    }

    public void MoveLeft()
    {
        System.Console.WriteLine("The bus move to left");
    }

    public void MoveRight()
    {
        System.Console.WriteLine("The bus move to right");
    }
}