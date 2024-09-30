using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameter
{
    public class Calculator
    {
       
       

        public int addnum(int num01,int num02,int num03=0, int num04 = 0) 
        { 
            return num01 + num03+num02+num04;
        }
        

    }
}
