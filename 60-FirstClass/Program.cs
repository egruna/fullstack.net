// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// در مثال زیر 10 و 20 نوشته می شود چون الویت کاننستراکتور تعرف شده توسط کاربر است منه پیشفرض
rectangle MyRectangle=new rectangle(10,20);
//  در کد بالا rectangle  دوم را می توان حذف کرد
MyRectangle.Print();

//// کدهای زیر برای زمانی است که فیلدها به صوت public وبود
//Console.WriteLine(MyRectangle.X);
//Console.WriteLine(MyRectangle.Y);
Console.ReadLine();

class rectangle
{
    //چون کانستراکتور ایجاد شده پس پیشفرض به فیلدهای کلاس می هد.
    // قلعدع نامگذاری private  _ با حروف کوچک است
    // access modifier :  public , private , ....
     private int _x;
     private int _y=3;
    //   و در بالا خطا گرفتاه میشود اگر فیلد ندهیم . می توان کانستراکتور تعرف کرد
    public rectangle(int x, int y)
    {
        _x = x;
        _y = y; 
    }


    public void Print()  
    {
        Console.WriteLine($"x={_x}");
        Console.WriteLine($"x={_y}");
    }
}

 