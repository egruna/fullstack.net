namespace _76_RandomNumber_Exercise;
public class randomGenerator
    {
        // به صورت توکار از randomnuber  استفاده می کند
        private readonly Random _random;
        private readonly int _MinValue;
        private readonly int _MaxValue;

        // بهتر است رندوم را در کانستراکتور بگیرد
        public randomGenerator(Random random, int _MinValue=1, int _MaxValue=10)
        {
            // یک رندوم تولید کن و به من پاس بده
            _random = random;
            _MaxValue = _MaxValue;
            _MinValue = _MinValue;
        }

        //ایجاد متدی برای گرفتن عدد رندوم

        public int Getrandom()
        {
            return _random.Next(_MinValue, _MaxValue+1);
        }
        

    }
