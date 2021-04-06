using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters_Step_317
{
    //Create Generic Class
    public class Employee<T>
    {
        //Create Generic List
        private List<T> things = new List<T>();
        //Create Generic Property
        public List<T> Things { get => things; set => things = value; }
    }
 
}
