// See https://aka.ms/new-console-template for more information
// استفاده از یک کانستنت
using _69_Constant_ReadOnly;

if (person.AdultAge > 15)
{
    Console.WriteLine(" Adult age is ,ore than 15 ....");
}

color myred = new color(255, 0, 0);
//  در ترکیب زیر رنگی قرمزری است که به ابی تغییر یافته 
// چگونه مانع از آن شویم؟
// ماهیت شی به اجزا آن وابسته است
//color myred = new color(255, 0, 0);
//myred.R = 0; myred.G = 0; myred.B = 255;
// vlaue object بهتر است immutable  طراحی شوند که قابل تغییر نباشند 

myred.R = 0; myred.G = 0; myred.B = 255;

Console.WriteLine("Hello, World!");
