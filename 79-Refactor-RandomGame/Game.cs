namespace _79_Refactor_RandomGame;
public class Game(randomGenerator randomGenerator, int maxGuessCount = 3)
{
    private int _randomNumber = randomGenerator.Getrandom();
    private int _maxGuessCount = maxGuessCount;

    public gameResult play()
    {
        int guessCount = 0;
        gameResult gameResult = gameResult.Lost;
        while (guessCount < _maxGuessCount)
        {
            guessCount++;


            if (!consoleReader.TryReadInt("Plase Enter A Valid Number:", out int value))
            {
                Console.WriteLine("Invalid Number!");
                continue;
            }

                if (value == _randomNumber)
                {

                gameResult=gameResult.Win;
                break;
                }
           
        }
        return gameResult;
      
    }

    public static void PrintResultMessage(gameResult result)
    {
        string message = result == gameResult.Win ?
            "You Win" :
            "You Lost";
        Console.WriteLine(message);
    }

}


