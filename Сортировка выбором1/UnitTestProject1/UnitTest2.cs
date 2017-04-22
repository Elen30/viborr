using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSelect
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod2()
        {
            //arrange
            int i;
            int s = 0;
            int len = 16;
            int[] mas = { 4, 5, 9, 8, 6, 1, 3, 2, 7, 10, 15, 14, 13, 10, 12, 11 };
            int[] res = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 11, 12, 13, 14, 15 };
            int[] fin = new int[len];

            //act
            Сортировка_выбором1.Program j = new Сортировка_выбором1.Program();
            fin = j.v(mas, len);

            //assert
            for (i = 0; i < len; i++)           //checking the array for correctness
            {
                if (res[i] == fin[i]) s++;
            }
            Assert.AreEqual(len, s);

        }
    }
}
