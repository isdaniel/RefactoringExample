using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SplitTemporaryVariable.Normal;
/*
* 說明：在一段程式中某個temp value超過一個函義以上(被不同地方付值且函義不一樣)，壞味道就跑出來了
* 
* 解決方式：解剖暫存變數的函義，給予每段暫存新的變數名稱，增加程式可讀性
*
* **/
namespace SplitTemporaryVariable
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //合適解說案例待補
            //NStore nStore = new NStore();
            //Assert.AreEqual(nStore.Discount(150),108);
            //Assert.AreEqual(nStore.Discount(10), 9);
        }
    }
}
