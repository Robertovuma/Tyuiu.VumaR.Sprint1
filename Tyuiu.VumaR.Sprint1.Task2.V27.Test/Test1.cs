
using Tyuiu.VumaR.Sprint1.Task2.V27.Lib;

namespace Tyuiu.VumaR.Sprint1.Task2.V27.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 2;
            var res = ds.CalculateSquarePerimetr(value);
            Assert.AreEqual(8, res);
        }
    }
}
