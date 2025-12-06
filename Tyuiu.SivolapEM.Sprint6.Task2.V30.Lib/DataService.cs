using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SivolapEM.Sprint6.Task2.V30.Lib
{
    public class DataService : ISprint6Task2V30
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] a = new double[stopValue - startValue + 1];
            int s = 0;

            for (int i = startValue; i <= stopValue; i++)
            {
                a[s] = Math.Round(((5 * i + 2.5) / (Math.Sin(i) + 3)) + 2 * i + Math.Cos(i), 2);
                s++;
            }

            return a;
        }
    }
}
