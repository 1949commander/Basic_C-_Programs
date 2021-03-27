using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Step_279
{
    class MathOPS
    {
        // Method with input of interger
        public int OverloadMath(int v1)
        {
            return v1 + 3;
        }
        // Method with input of Decimal(Float)
        public int OverloadMath(float v2)
        {
            return Convert.ToInt32(v2 - 23);
            
        }
        // Method with input of String
        public int OverloadMath(string v3)
        {
            return Convert.ToInt32(v3) * 3;
        }


    }
}
