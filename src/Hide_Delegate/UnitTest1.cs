using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hide_Delegate.Normal;
using Hide_Delegate.Refactoring;
/*
 * 說明：封裝是將物件要隱藏的資料隱藏,必須公開才公開
 * 但有時候的壞味道是 透過A物件呼叫B物件引用C物件，導致三個物件耦合性增加
 * 
 * 解決方式：在B物件中進一步封裝C物件
 *
 * **/
namespace Hide_Delegate
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Normal1()
        {
            PersonN p1 = new PersonN() { Name = "Tom" };
            PersonN mannger = new PersonN() { Name = "Amy" };
            p1.SetDepartment(new Normal.Department(mannger));

            //這裡就是壞味道 讓外部知道你呼叫的順序 所以我們需要重購在封裝
            PersonN except = new PersonN() { Name = "Amy" };
            PersonN reuslt = p1.GetDepartment().GetMannger();


            Assert.AreEqual(except.Name,reuslt.Name);
        }

        [TestMethod]
        public void Refactoring1()
        {
            PersonR p1 = new PersonR() { Name = "Tom" };
            PersonR mannger = new PersonR() { Name = "Amy" };
            p1.SetDepartment(new Refactoring.Department(mannger));

            PersonR except = new PersonR() { Name = "Amy" };
            PersonR reuslt = p1.GetMannager();
            Assert.AreEqual(except.Name, reuslt.Name);
        }
    }
}
