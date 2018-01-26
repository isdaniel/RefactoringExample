using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SplitTemporaryVariable.Normal
{
    public class NStore
    {
        /// <summary>
        /// 在這裡面購買的東西會有下面算法
        /// 1.折扣打八折
        /// 2.折扣完超過100元 再打九折 - 10 元
        /// 3.最後在加10%稅收
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        public double Discount(double price)
        {
            double tempPrice = price;

            price = price *0.8;

            if (tempPrice > 100)
                price = (tempPrice * 0.9 )- 10;

            price = price * 1.1;

            return Math.Round(price);
        }
    }
}
