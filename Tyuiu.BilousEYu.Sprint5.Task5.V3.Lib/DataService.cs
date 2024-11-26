using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BilousEYu.Sprint5.Task5.V3.Lib
{
    public class DataService : ISprint5Task5V3
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(",") == false)
                    {
                        res = res + Convert.ToDouble(line);
                    }
                }
                return Math.Round(res, 3);
            }
        }
    }
}
