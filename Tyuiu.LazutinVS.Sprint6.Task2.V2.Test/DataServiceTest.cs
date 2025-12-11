using Tyuiu.LazutinVS.Sprint6.Task2.V2.Lib;

namespace Tyuiu.LazutinVS.Sprint6.Task2.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = -5;
            int z = 5;
            double[] d = { 6.49, -9.88, -12.26, -4.60, 0.52, 4.00, -0.75, 4.55, 12.23, 9.86, -6.50 };
            var res = ds.GetMassFunction(a, z);
            CollectionAssert.AreEqual(res, d);
        }
    }
}
