using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReplaceArrayWithObject.Refactoring;
/*
* 名稱：ReplaceArrayWithObject(使用物件替代陣列)
* 
* 說明：Array陣列(不只是Array存放集合都可以用此重構方法)
* 使用連續記憶體存放同類型的數值，但使用陣列的Index並不知道他放物件的含意
* 
* 解決方式：使用一個物件的變數來賦予陣列欄位生命，而不是冷冰冰的記憶體空間(Index)..
*
* **/
namespace ReplaceArrayWithObject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            #region Normal
            string[] baseBallCourt = new string[100];
            baseBallCourt[0] = "1000$";//Price
            baseBallCourt[1] = "Tom";//Boss
            baseBallCourt[2] = "1980";//Build on
            //後續維護人員 必須依靠註解來了解 baseBall陣列的Index代表涵義。
            //這個很不人性化，我們就可以把陣列封裝成一個物件 
            #endregion

            //將陣列封裝到物件中
            BaseBallCourt court = new BaseBallCourt(baseBallCourt);

            //測試通過...看起來美化很多了吧^^
            Assert.AreEqual(court.Price, baseBallCourt[0]);
            Assert.AreEqual(court.Boss, baseBallCourt[1]);
            Assert.AreEqual(court.BuildOn, baseBallCourt[2]);
        }
    }
}
