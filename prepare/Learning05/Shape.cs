public abstract class Shape
{
    private string _color;

    
    public Shape(string color)
    {
        _color = color;
    }

    // Getter and setter for color
    public string Color
    {
        get { return _color; }
        set { _color = value; }
    }

    // Virtual method to get area
    public abstract double GetArea();
}