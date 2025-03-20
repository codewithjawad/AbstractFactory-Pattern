using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorytask
{
    public  class Employees
    {
        internal class UManagement : IEmployee
        {
            public String Annualsal()
            {
                return "Salary is 100k $";
            }
            public String Monthlysal()
            {
                return "Salary is 8k $";
            }
        }
        internal class PEmployee : IEmployee
        {
            public string Annualsal()
            {
                return "Salary is 700k RS";
            }
            public String Monthlysal()
            {
                return "Salary is 7k RS";
            }
        }
        internal class Interns : IEmployee
        {
            public String Annualsal()
            {
                return "Salary is 200k RS";
            }
            public String Monthlysal()
            {
                return "Salary is 15K (Stipend)";
            }
        }
    }
}
