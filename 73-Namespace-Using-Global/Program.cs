global using _73_Namespace_Using_Global.Seconds;

using _73_Namespace_Using_Global.Firsts;
using NewAliayName = _73_Namespace_Using_Global.Firsts.First1;

_73_Namespace_Using_Global.Firsts.First1 MyFirst1 = new _73_Namespace_Using_Global.Firsts.First1(); //  قبل از تعریف using
First1 MyFirst11 = new First1(); // بعد از تعریف using 
NewAliayName myFirst111withAlias= new NewAliayName(); //  بعد از تریف آلیاس
second1 MySecont1WithGlobal = new second1(); //  بعد از ست شدن به عنوان گلوبال
Third1 MyThird1whitGlobalInGlobalFile = new Third1(); //  بعد از ست شدن نیم اسپیس در گلوبال در فایل مجزا از پروگرام
Console.WriteLine("Hello, World!");
