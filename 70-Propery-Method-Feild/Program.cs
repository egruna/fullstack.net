// See https://aka.ms/new-console-template for more information
/*
 * Field- متغیر - معمولا پاریویت - منطقنی نداشته و به صورت مستقیم   استفاده می شود
 * Property - واسطی برای دستری فیلدها است - معمولا پابلیک - شامل منطق اعتبار سنجی است - و از طریق گت و ست استفاده می شوند
 * Method  -   تابع هستد - معمولا پابلیک است -  شامل منطق پیچیده است و به صورت مستقیم راخوانی می شوند.
 * 
 */
person employee = new person();// تعریف کلاس و ایجاد یک ابجکت از کلاس پرسون

employee.AgeProperty = 10;// مقدار دهی از طریق پراپرتی به فیلد پرایویت شده
employee.DisplayAge();// استفاده از متد

Console.ReadLine();
class person()
{
    private int age; // فیلد

    public int AgeProperty
    {
        get { return age; }
        set { age = value; }
    }

    public void DisplayAge()
    {
        Console.WriteLine($"Age: {age}");
    }



}


