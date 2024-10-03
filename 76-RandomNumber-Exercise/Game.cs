namespace _76_RandomNumber_Exercise;

public class Game(randomGenerator randomGenerator,int maxGuessCount=3)
{
    private int _randomNumber = randomGenerator.Getrandom();
    private int _maxGuessCount = maxGuessCount;

    public void play()
    {
        int guessCount = 0;
        while (guessCount < _maxGuessCount) 
        {
           guessCount++;
            int value;
            if (consoleReader.TryReadInt("Plase Enter A Valid Number:", out value))
            {
                if(value == _randomNumber)
                {
                    Console.WriteLine("You Win.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Invalid Number!");
            }
        }
        Console.WriteLine("You Loss.");
    }
}

// وظیفه کلاس game خواندن عدد حدسی نیست پس کلاس مستقل ایجاد می کنیم.
public static class consoleReader
{
    // تابعی برای گرفتن عدد از کاربر اگر عدد نبود فالس بر میگردد وگنه همان عدد خروجی تابع است
       public static bool TryReadInt(string message, out int value)
    {
        Console.Write(message);
        return int.TryParse(Console.ReadLine(), out value);
    }
}