
using Tyuiu.VumaR.Sprint1.Task4.V3.Lib;

namespace Tyuiu.VumaR.Sprint1.Task4.V3.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x, y;
            x = 27;
            y = 24;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1, res);
        }
    }
}
