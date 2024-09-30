using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _69_Constant_ReadOnly
{
    internal class color
    {
        public readonly int R;
        public readonly int G;
        public readonly int B;

        /*  ....
         *  اگر ابجکتی بسازیم که متغیرهای آن ریدالنی باشد ابگتش immutable  می شود
         *  در تعریف بالا بدلیل ریدانلی امکان تغییر بعد از تعریف ابجکن نیست
         *  
         */
        public color(int r, int g, int b)
        {
            R = r;
            G = g;
            B = b;
        }
    }
}
