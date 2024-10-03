/*تولید عدد رندوم بین 0 الی 10 - سه بار فرصت حدس یرای کاربر
 *اگر حدس درست زد پیام تبریک-وارد کردن مقدار غیر عددی و اشتباه سوختن یکی از فرصت 
 *های سه گانه و بعد از سه بار اشتباه خروج از برنامه
 *حل ساده در انتهای همین صفحه بدون روال هاس اصلی کدنویسی
 */
using _76_RandomNumber_Exercise;
randomGenerator myrandomGenerator  = new randomGenerator(new Random());
Game game = new(myrandomGenerator);
game.play();
Console.ReadLine();











// حل برنامه در ساده ترین حالت و بدون ولیدیشن و کلاس ها در زیر
//Random randomNum=new Random();
//int myRandom = randomNum.Next(0, 11);
//Console.WriteLine($"Random Number is : {myRandom}");
////int Realnumber = int.Parse(Console.ReadLine());
//for(int i = 1; i <=3 ; i++)
//{
//    Console.WriteLine("Guess the Number:");
//    int guessNumber=int.Parse(Console.ReadLine());
//    if(guessNumber == myRandom)
//    {
//        Console.WriteLine("Good Job");
//        break;
//    }
//    else
//    {
//        Console.WriteLine("Wrong!!!");
//    }
//}
//Console.ReadLine();