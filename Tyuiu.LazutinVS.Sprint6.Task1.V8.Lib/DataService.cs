using tyuiu.cources.programming.interfaces.Sprint6;


namespace Tyuiu.LazutinVS.Sprint6.Task1.V8.Lib
{
    public class DataService : ISprint6Task1V8
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];

            int index = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = x - 0.4;

                if (Math.Abs(denominator) < 0.000001) 
                {
                    valueArray[index] = 0; 
                }
                else
                {
                    double numerator = Math.Cos(x);
                    double term1 = numerator / denominator;
                    double term2 = Math.Sin(x) * 8 * x;

                    double result = term1 + term2 + 2;
                    valueArray[index] = Math.Round(result, 2);
                }

                index++;
            }

            return valueArray;
        }
    }
}
