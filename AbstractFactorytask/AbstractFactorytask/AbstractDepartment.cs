using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorytask
{
    abstract class AbstractDepartment
    {
            public abstract IEmployee Createemp(String type);
    }
}
