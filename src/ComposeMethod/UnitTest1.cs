using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComposeMethod.Normal;
using ComposeMethod.Refactoring;

/*
 * 說明：一個方法太複雜(動作太多)或是太長，第一眼看不出方法功能時，可考慮把它提取成小方法
 * 
 * 解決方式：
 * 1.把每個動作附上註解(方便標示[提取方法])
 * 2.提出方法不動到內部邏輯
 * 3.測試通過
 * 4.持續到可簡單了解方法功能
 * **/
namespace ComposeMethod
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            #region Normal
            ListContainer_N<int> list = new ListContainer_N<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            Assert.AreEqual(14, list.Size);
            #endregion

            #region Refactoring
            ListContainer_R<int> list2 = new ListContainer_R<int>();

            list2.Add(1);
            list2.Add(2);
            list2.Add(3);
            list2.Add(4);

            Assert.AreEqual(14, list2.Size);
            #endregion


        }
    }
}
