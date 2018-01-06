using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NullObject.Normal;
using NullObject.Refactoring;

namespace NullObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Refactoring.Customer customer = new Refactoring.Customer();
            //customer.PickBook(new Refactoring.Book() { Name = "novice", Price = 100 });
            customer.BuyBook();


            Console.ReadKey();
        }
    }
}
