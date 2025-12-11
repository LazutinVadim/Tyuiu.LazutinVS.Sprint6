using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.LazutinVS.Sprint6.Task2.V2.Lib
{
    public class DataService : ISprint6Task2V2
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] mass;
            int len = stopValue - startValue + 1;
            mass = new double[len];
            double y;
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                y = Math.Sin(i) + 2 / (3 * i + 0.5) - 2 * Math.Cos(i) * 2 * i;
                mass[count] = Math.Round(y, 2);
                count++;

            }
            return mass;
        }
    }
}
