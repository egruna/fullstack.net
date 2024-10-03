
namespace _79_Refactor_RandomGame;
public class randomGenerator
{
    private readonly Random _random;
    private readonly int _MinValue;
    private readonly int _MaxValue;
    public randomGenerator(Random random, int _MinValue = 1, int _MaxValue = 10)
    {
        _random = random;
        _MaxValue = _MaxValue;
        _MinValue = _MinValue;
    }

   
    public int Getrandom()
    {
        return _random.Next(_MinValue, _MaxValue + 1);
    }


}
