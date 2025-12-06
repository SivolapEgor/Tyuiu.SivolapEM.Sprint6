using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SivolapEM.Sprint6.Task4.V22.Lib
{
    public class DataService : ISprint6Task4V22
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = new double[11];
            int i = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (2 * x - 1 == 0)
                {
                    res[i] = 0;
                    i++;
                    continue;
                }
                res[i] = Math.Round(Math.Sin(x) + Math.Cos(2*x)/2 - 1.5 * x, 2);
                i++;
            }

            return res;
        }
    }
}
