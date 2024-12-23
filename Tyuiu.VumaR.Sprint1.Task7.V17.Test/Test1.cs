
using Tyuiu.VumaR.Sprint1.Task7.V17.Lib;

namespace Tyuiu.VumaR.Sprint1.Task7.V17.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x, y;
            x = 0;
            y = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(-12.656, res);
        }
    }
}
