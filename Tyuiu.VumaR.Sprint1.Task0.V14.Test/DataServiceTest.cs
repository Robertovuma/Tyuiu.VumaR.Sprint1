﻿
using Tyuiu.VumaR.Sprint1.Task0.V14.Lib;

namespace Tyuiu.VumaR.Sprint1.Task0.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(25, res);
        }
    }
}
