using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveMethod.Normal
{
    public class Person
    {
        public Person(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }
        public int Age { get; set; }
        public string Name { get; set; }
    }

    public class ShowInfo
    {
        public string Show(Person person)
        {
            return $"Age:{person.Age} Name:{person.Name}";
        }
    }
}
