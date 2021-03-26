using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Step_279
{
    class MathOPS
    {

        public MathOPS(int v1, float v2, string v3)
        {
            V1 = v1 + 3;
            V2 = Convert.ToInt32(v2 - 23);
            V3 = Convert.ToInt32(v3) * 3;
        }

        public int V1 { get; set; }
        public int V2 { get; set; }
        public int V3 { get; set; }
    }
}
