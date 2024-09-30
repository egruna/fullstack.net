using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _69_Constant_ReadOnly
{
    internal class person
    {
        public string firstname;
        public string lastname;
        public int age;
        // constant  ها باید مقدار اولیه داشته باشند
        //  میت.وان از این مقدار ثابت جای دیگر نیز استفاده کرد.
        // نکات constant
        // در زمان کامپایل مقدار به آم اختصاص داده می شود و تغییر پیدا نمی کند لذا امکان تعرف به صورت زیر نیست
        /*
         * public const int AdultAge = GetAdultAge();
         * ...
         * public int GetAdultAge()=>20;
         * 
         *  برای تعریف در زمان رانتایم:
         *  به صورتی که بعد از مقدار دهی قابل تغیر نباشد در ران تایم:
         *  در این حالت از readonly  استفاده می شود
         *  ....
         *  اگر ابجکتی بسازیم که متغیرهای آن ریدالنی باشد ابگتش immutable  می شود
         */
        public const int AdultAge = 18;
        public readonly int AdultAgeReadonly; //  قابل مقدار دهی در اینجا مستقیم یا در کانستراکتور

        public person(string firstname, string lastname, int age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
            AdultAgeReadonly=GetAdultAge();
        }

        private int GetAdultAge()
        {
            throw new NotImplementedException();
        }

        public void ForAdult()
        {
            //  اعداد ثابت را اینطوری تعریف نمی کنند!   
            // یک constant  تعریف می شود
            //if (age > 18)
            if (age > AdultAge)
            {
                //  جون ریدانلی و در مد رانتایم است امکان تغیر ندارد کد زیر خطا می دهد
                // AdultAgeReadonly = 23;
            }
        }
    }

    
}
