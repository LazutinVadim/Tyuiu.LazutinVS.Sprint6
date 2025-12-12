using Tyuiu.LazutinVS.Sprint6.Task3.V20.Lib;

namespace Tyuiu.LazutinVS.Sprint6.Task3.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService service = new DataService();

        [TestMethod]
        public void CalculateTest()
        {
            int[,] testArray = { {1, 1, 1, 1, 1, },
                                 {1, 1, 1, 1, 1, },
                                 {1, 1, 1, 1, 1, },
                                 {1, 1, 1, 1, 1, },
                                 {2, 2, 2, 2, 2, } };
            int[,] testArray1 = { {1, 1, 1, 1, 1, },
                                  {1, 1, 1, 1, 1, },
                                  {1, 1, 1, 1, 1, },
                                  {1, 1, 1, 1, 1, },
                                  {0, 0, 0, 0, 0, } };
            CollectionAssert.AreEqual(testArray1, service.Calculate(testArray));
        }
    }
}
