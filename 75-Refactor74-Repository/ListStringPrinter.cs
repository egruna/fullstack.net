namespace _75_Refactor74_Repository;

// طراحی کلاسی مستقل فقط برای لیست استرینگ
// ریپاسیتوری برای ارتبط با بخش مدیریت داده که شامل تکست. دیتابیس  و ... است

public class ListStringPrinter()
{
    public void Print(List<string>input)
    {
        // مدیریت نمایش مثلا در وب سا ایمیل  و ...
        string productFormated = string.Join(" , ", input);
        Console.WriteLine(productFormated);
    }
}
