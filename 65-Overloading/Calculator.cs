using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _65_Overloading
{
    public class Calculator
    {
        // اورلودینگ در متدها شامل تغییر تعداد متغیر و نوع متغیر
        // علامت => برای explresion bodied mothod  است و خلاصه نویسی می شود.
        // درس 66 => 
        public int addnum(int num01,int num02) { return num01 + num02; }
        public int addnum(int num01,int num02,int num03) { return num01 + num03+num02; }
        public long addnum(long num01,long num02,long num03)=> num01 + num03+num02;
    }
}
