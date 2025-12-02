using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SivolapEM.Sprint6.Task0.V8.Lib
{
    public class DataService : ISprint6Task0V8
    {
        public double Calculate(int x)
        {
            double y = (2 * x * x - 1) / Math.Pow(x * x - 2, 0.5);
            return Math.Round(y, 3);
        }
    }
}
