
Console.WriteLine("Hello, World!");
Rectangle rectangle = new(10, 20);
Console.WriteLine(rectangle.CalcuateArea());

Console.ReadLine();

class Rectangle
{
    
    private int _width=3;
    private int _height = 5;
    
    public Rectangle(int width, int height)
    {
        _width = width;
        _height = height;
    }

    // متدها یا به تعبیری توابع اکسس موریفایر دارند و متغییر وروردی می توانند داشته باشند 
    // و با return  امکان خروجی دارند
    // defult access modifier for method is private!
    // متدها کاری هستند که انجام می شوند و نامگذاری ان بهتر است با یک فعل باشد.
    public int CalcuateArea()
    {
        return _width * _height;
    }

}

