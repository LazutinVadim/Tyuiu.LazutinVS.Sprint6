using Tyuiu.LazutinVS.Sprint6.Task0.V5.Lib;

namespace Tyuiu.LazutinVS.Sprint6.Task0.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void TestMethod1()
        {
            int x = 5;
            double wait = -114.5;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
