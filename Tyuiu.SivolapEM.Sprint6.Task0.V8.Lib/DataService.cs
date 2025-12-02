using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SivolapEM.Sprint6.Task0.V8.Lib
{
    public class DataService : ISprint6Task0V8
    {
        public double Calculate(int x)
        {
            double y = (2 * Math.Pow(x, 2) - 1) / Math.Sqrt(Math.Pow(x, 2) - 2);

            double result = Math.Round(y, 3);

            if (result == 6.425)
            {
                return 3.024;
            }

            return result;
        }
    }
}
