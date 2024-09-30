// See https://aka.ms/new-console-template for more information
Statelesscalculator Mystatelesscalculator = new Statelesscalculator();
Mystatelesscalculator.sum(10, 20);
Statelesscalculator.sub(10, 20);// استاتیک تعریف شده و وابسته به متد تیست
Console.WriteLine("Hello, World!");

// در کد بالا هم کنسول اینستنس ساخته نشده به نظر استاتیک در پشت تعریف شده
// حالت static
// برای کل کلاس هم قابل استفاده است
// از این حالت برای محدود کردن تعداد استنس های ساخته شده از کلاس  و ...
// استفاده می شود.
for (int i = 0; i < car.MaxValue; i++)
{
    car mycar=new car();
    Console.WriteLine($"{i}");
}
//car.MaxValue;
Console.ReadLine();