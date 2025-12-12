using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.LazutinVS.Sprint6.Task4.V11.Lib
{
    public class DataService : ISprint6Task4V11
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result;
            int len = (stopValue - startValue) + 1;
            result = new double[len];
            int count = 0;
            double y;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(Math.Cos(x) + (Math.Sin(x)) / (2 - 2 * x) - 4 * x, 2);
                if (2 - 2 * x != 0)
                {
                    result[count] = y;
                    count++;
                }
                else
                {
                    result[count] = 0;
                    count++;
                }
            }
            return result;
        }
    }
}
