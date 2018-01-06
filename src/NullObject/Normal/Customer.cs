using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject.Normal
{
    public class Book
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }

    public class Customer
    {
        private Book _book;

        public void PickBook(Book book)
        {
            _book = book;
        }

        public void BuyBook()
        {
            if (_book == null)
            {
                Console.WriteLine("Didn't buy anything!");
            }
            else
            {
                Console.WriteLine($"Buying {_book.Name}  Price is:{_book.Price}");
            }
        }
    }
}
