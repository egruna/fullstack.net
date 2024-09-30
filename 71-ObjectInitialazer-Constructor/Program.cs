BookWithConstructor bookWithConstrutor = new BookWithConstructor("book name constractor","book Desc cunstractor");
Console.WriteLine($"with constructor ::::{bookWithConstrutor.name} , :{bookWithConstrutor.description}");

bookWithoutCostructor bookWithoutconstructor = new bookWithoutCostructor();
bookWithoutconstructor.name = "Book without const...";
bookWithoutconstructor.description = " descrip... without constru...";
Console.WriteLine($"{bookWithoutconstructor.name}, {bookWithoutconstructor.description}");

bookWithoutCostructor bookObjectInitialazer = new bookWithoutCostructor
{
    // sYNTAX "  Object Initialyzer  سینتکس 
    // می توان برخی از فیلدها را مقدار دهی کرد 
    //initilization is after construction 
    //  پس مقدار object initilization  در خروجی نمایش  داده میشود
    // هنگام تعریف اگر init  ست شود  بعد از initilization  امکان تغییر وجود ندارد
    // خطای bookObjectInitialazer.description
    name = "bookname OI"
};
bookObjectInitialazer.description = "descrip... OI out of {}";
Console.WriteLine($"{ bookObjectInitialazer.name},{ bookObjectInitialazer.description}");

Console.ReadLine();
public class BookWithConstructor
{
    // اگر کانستکراتور ست شود باید مقدایر را پاس دهیم و مقدار دهیم

    public BookWithConstructor(string name, string description)
    {
        // زمانی که constructor  تعریف می شود به صورت زیر بدون مقدار نمی شود اینیشیلایز کرد
        // Book book = new Book();
        this.name = name;
        this.description = description;
    }

    public string name { get; set; }
    public string description { get; set; }

}

public class bookWithoutCostructor()
{
    // برای اجبار به مقداردهی در زمان عدم وجود کانسنراکتور کلمه required  برای فیلد ست می شود
    // مثال   name
    public required string name { get; set; }    
    public string description { get; init; }
    // در متد set  امکان تعریف ولیدیشن و ... وجود دارد
}