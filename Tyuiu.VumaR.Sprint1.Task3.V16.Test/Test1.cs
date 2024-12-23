
using Tyuiu.VumaR.Sprint1.Task3.V16.Lib;


namespace Tyuiu.VumaR.Sprint1.Task3.V16.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x1 = 1;
            double x2 = 1;
            var res = ds.CoeffOfQuadraticEquation(x1, x2);
            Assert.AreEqual(-2, res);
        }
    }
}
