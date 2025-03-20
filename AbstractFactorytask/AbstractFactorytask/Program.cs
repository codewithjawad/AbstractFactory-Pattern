using System;
using static AbstractFactorytask.Management;

namespace AbstractFactorytask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract FActory Task\n");
            AbstractDepartment d1 = new Management();
                IEmployee intern = d1.Createemp("intern");
                Console.WriteLine(intern.Annualsal());
                AbstractDepartment d2 = new Development();
                IEmployee permanent = d2.Createemp("permanent employee");
                Console.WriteLine(permanent.Annualsal());
                AbstractDepartment d3 = new Workers();
                IEmployee upper = d3.Createemp("upper management");
                Console.WriteLine(upper.Annualsal());
               
            
        }
    }
}

