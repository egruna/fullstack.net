

public class Rectangle
{

    private int _width = 3;
    private int _height = 5;

    public Rectangle(int width, int height)
    {
        _width = width;
        _height = height;
    }
    public int CalcuateArea()
    {
        return _width * _height;
    }

}

