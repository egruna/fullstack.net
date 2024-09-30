// See https://aka.ms/new-console-template for more information
//اگر کلاسی برای کار نیاز به متغییر و وضعیت داشته باشد
//آن کلاس statefull  است.
// مثلا برای توابعی که مقادیر آن مستقل از کارکرد است به آن stateless  گویند
// برای استفاده از  Statelesscalculator زیر
//باید اینستنس از آن ساخته 
// در این مثال چون وابستگی به نمونه ای از کلاس وجود ندارد
// و برای خروج وابستگی متد از اینستنس و وابسته به کل کلاس باشد 
// کلمه کلیدی static  برای متد اینکار را انجام می دهد.
// مثلا sub
using System.Reflection.Emit;

public class Statelesscalculator()
{
    public int sum(int num01, int num02) 
    {
        return num01+ num02;
    }
    public static int sub(int num01, int num02)
    {
        return num01 - num02;
    }
}

// کلاس زیر تنوع تعریف ها را دارد
// در داخل توابع استاتیک از instance member  استفاده شود؟

public class car
{
    // متغیرهای کانستکنت از نوع استاتیک هستند

    public const int MaxValue = 100;
    // امکان تعریف کانستکتراکتور به صورت استاتیک هم هست
    // در این حالت به مقادیر استاتیک آن دسترسی داریم
    public car()
    {
       if(instancecount > 99)
        {
            throw new Exception("Invalid New Instance");
        }
        instancecount += 1;
        // معدود کردن تعداد اسنیتنس تعریف شده به زیر 99
    }

    public static string Description => "This is my car class";
    public static int instancecount
    {
        get;
        private set;
        //  هروقت از این اینستنس استفاده شده کانتر بیندازد

    }
    public int color { get; set; }
    public int speed { get; private set; }
    public void addspeed(int vlaue)
    {
         // امکان استفادهداز متغیر موجود در کلاس در تابه هست
        string localDescription = Description;
        speed += vlaue;
    }
    public static void Print()
    {
        Console.WriteLine($"{Description}");
        //امکان استقاده از speed نیست
        // چون مربوط به یک اسنستنس از کلاس اصلی است
        // درون متد و پراپرتی  استاتیک امکان استفاده از متدها و فیلدها و توابع غیراستاتیک
        // درسترسی داشته باشیم
        //Console.WriteLine($"car speed is : {speed }");
    }
}