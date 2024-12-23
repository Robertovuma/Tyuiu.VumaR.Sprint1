
using Tyuiu.VumaR.Sprint1.Task6.V9.Lib;

namespace Tyuiu.VumaR.Sprint1.Task6.V9.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "Название проектов";

            var res = ds.MoveLetterToStart(value);
            Assert.AreEqual("еНазвани впроекто", res);
        }
    }
}
