using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject.Refactoring
{
    public interface NULL { }
    public class Book
    {
        public virtual string Name { get; set; }
        public virtual int Price { get; set; }
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
            Console.WriteLine($"Buying { GetBook().Name}  Price is:{ GetBook().Price}");           
        }

        /// <summary>
        /// 在這邊判斷是否為空物件
        /// </summary>
        /// <returns></returns>
        private Book GetBook()
        {
            return _book == null ? new NullBook() : _book;
        }
    }

    /// <summary>
    /// 製作一個空物件類別 裡面可以擁有自己的狀態
    /// 有NULL介面 代表是空物件
    /// </summary>
    public class NullBook : Book , NULL
    {

        public override string Name { get => "Empty"; set => base.Name = value; }

        public override int Price { get => 0; set => base.Price = value; }
    }
}
