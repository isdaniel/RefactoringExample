using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hide_Delegate.Refactoring
{
    public class PersonR
    {
        public string Name { get; set; }

        private Department _department;

        //public Department GetDepartment()
        //{
        //    return _department;
        //}

        /// <summary>
        /// 重構後外面就不知道Person呼叫的順序了
        /// </summary>
        /// <returns></returns>
        public PersonR GetMannager()
        {
            return _department.GetMannger();
        }
        public void SetDepartment(Department arg)
        {
            _department = arg;
        }
    }

    public class Department
    {
        private PersonR _mannger;

        public Department(PersonR p)
        {
            _mannger = p;
        }

        public PersonR GetMannger()
        {
            return _mannger;
        }
    }
}
