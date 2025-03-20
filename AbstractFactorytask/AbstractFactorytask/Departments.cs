using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using static AbstractFactorytask.Employees;

namespace AbstractFactorytask
{
    internal class Management : AbstractDepartment
    {
        public override IEmployee Createemp(String type)
        {
            switch (type.ToLower())
            {
                case "intern":
                    return new Interns();
                    break;
                case "upper management":
                    return new UManagement();
                    break;
                case "permanent employee":
                    return new PEmployee();
                    break;
                default:
                    return null;
                    break;

            }
        }
        public  class Development : AbstractDepartment
        {
            public override IEmployee Createemp(String type)
            {
                switch (type.ToLower())
                {
                    case "intern":
                        return new Interns();
                        break;
                    case "upper management":
                        return new UManagement();
                        break;
                    case "permanent employee":
                        return new PEmployee();
                        break;
                    default:
                        return null;
                        break;
                }
            }
        }
        public class Workers : AbstractDepartment
        {
            public override IEmployee Createemp(String type)
            {
                switch (type.ToLower())
                {
                    case "intern":
                        return new Interns();
                        break;
                    case "upper management":
                        return new UManagement();
                        break;
                    case "permanent employee":
                        return new PEmployee();
                        break;
                    default:
                        return null;
                        break;
                }
            }

        }
    }
}


