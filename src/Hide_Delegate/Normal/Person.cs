using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hide_Delegate.Normal
{
    public class PersonN
    {
        public string Name { get; set; }

        private Department _department;

        public Department GetDepartment()
        {
            return _department;
        }
        public void SetDepartment(Department arg)
        {
            _department = arg;
        }
    }

    public class Department
    {
        private  PersonN _mannger;

        public Department(PersonN p)
        {
            _mannger = p;
        }

        public PersonN GetMannger()
        {
            return _mannger;
        }
    }
}
