using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overload_Step_313
{
    public class Employee : Person
    {
        public int ID
        { get; set; }

        public static bool operator ==(Employee employee_one, Employee employee_two)
        {
            if (employee_one.ID == employee_two.ID)
                return employee_one.ID == employee_two.ID;  
            else
                return false;

        }

        public static bool operator !=(Employee employee_one, Employee employee_two)
        {
            return employee_one.ID != employee_two.ID;
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false; //optional. depends on logic
            return ID.Equals(((Employee)obj).ID);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

