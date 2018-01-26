using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
/*
 * 說明：一個類別的方法太過依賴另一個類別的欄位時
        就考慮把此方法搬移到他因該去的地方（引用較多的那個類別）
        基準大約為使用一半以上
 * 
 * 解決方式：把A類方法移動至B類別，把方法中所需B類別參數拿掉，編譯測試
 *
 * 案例解釋：一個Person類別，有兩個欄位int Age和string Name;
 *          另一個類別ShowInfo 有一個方法Show 傳入參數Person
 *          到這裡就知道ShowInfo.Show方法,放在Person比較合適,那就大膽去吧!!
 *          搬移->編譯->測試
 * 
 * **/
namespace MoveMethod
{
    [TestClass]
    public class UnitTest1
    {
        private int Age = 10;
        private string Name = "daniel";

        [TestMethod]
        public void NormalTest()
        {
            string exceptResult = $"Age:{Age} Name:{Name}";
            Normal.Person p = new Normal.Person(Age, Name);
            Normal.ShowInfo show = new Normal.ShowInfo();
            Assert.AreEqual(show.Show(p), exceptResult);
        }

        [TestMethod]
        public void RefactoringTest()
        {
            string exceptResult = $"Age:{Age} Name:{Name}";
            Refactoring.Person p = new Refactoring.Person(Age, Name);
            Assert.AreEqual(p.Show(), exceptResult);
        }
    }
}
