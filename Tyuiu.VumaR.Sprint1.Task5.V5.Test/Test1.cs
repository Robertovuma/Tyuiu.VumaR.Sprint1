
using Tyuiu.VumaR.Sprint1.Task5.V5.Lib;

namespace Tyuiu.VumaR.Sprint1.Task5.V5.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int k = 12;
            int n = ds.Calculate(k);
            int res = Convert.ToInt32(n);
            int wait = 5;
            Assert.AreEqual(wait, res);
        }
    }
}
