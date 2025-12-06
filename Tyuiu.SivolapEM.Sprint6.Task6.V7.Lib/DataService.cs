using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SivolapEM.Sprint6.Task6.V7.Lib
{
    public class DataService : ISprint6Task6V7
    {
        public string CollectTextFromFile(string path)
        {
            string result = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                string[] fragments;
                while ((line = reader.ReadLine()) != null)
                {
                    fragments = line.Split(' ');
                    result += fragments.Length > 2 ? fragments[2] + " " : "";
                }
            }
            result = result.Trim();
            return result;
        }
    }
}
