using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NullObject.Normal;
using NullObject.Refactoring;

namespace NullObject
{
    /*
     * 說明：本項重構用於 null物件需要判斷且有特定意義回傳狀態時使用
     * 只有當大多數客戶程式碼都要求null object做出回應時,這樣的行為搬出才有意義
     * 
     * 解決方式：Null Object當作一個類別，賦予它應有的狀態
     *
     * **/
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
