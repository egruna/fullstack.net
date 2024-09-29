// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

rectangle MyRectangle = new rectangle(10, 20);
MyRectangle.Print();

Console.ReadLine();

class rectangle(int x, int y)
{   
    private int _x=x;
    private int _y =y;
    // وقتی ایجاد می شود دیگر کانستراکتور پیشفرض نداریم و سفارشی شده مثل زیر
    // امکانات کانستراکتور سفازشی
    // دریافت پاراتر وروردی 
    //امکان تعریف ولیدیشن
    // همیشه نیاز به ولیدیشن نیست و می شود از primary constructor  استفاده کرد.

    // جلوی اسم کلاس متغیرها را تعریف می کنیم   
    //-----

    ////public rectangle(int x, int y)
    ////{
    ////    if (y < 0)
    ////        throw new Exception("Invalid x!");
    ////    if (x < 0)
    ////        throw new Exception("Invalid y!");
    ////    _x = x;
    ////    _y = y;
    ////}


    public void Print()
    {
        Console.WriteLine($"x={_x}");
        Console.WriteLine($"x={_y}");
    }
}

