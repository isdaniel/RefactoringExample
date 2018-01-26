using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveMethod.Refactoring
{
    public class Person
    {
        public Person(int age,string name) {
            this.Age = age;
            this.Name = name;
        }

        public int Age { get; set; }
        public string Name { get; set; }

        public string Show()
        {
            return $"Age:{Age} Name:{Name}";
        }
    }
}
