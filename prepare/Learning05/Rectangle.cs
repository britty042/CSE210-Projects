public class Rectangle : Shape
{
    private double _width;
    private double _length;

    public Rectangle(string color, int width, int length) : base(color)
    {
        _width = width;
        _length = length;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}