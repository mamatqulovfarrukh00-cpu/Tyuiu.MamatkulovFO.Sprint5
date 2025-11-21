using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MamatkulovFO.Sprint5.Task4.V27.Lib
{
    public class DataService : ISprint5Task4V27
    {
        public double LoadFromDataFile(string path)
        {
            string dir = Path.GetDirectoryName(path);
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            if (!File.Exists(path))
                File.WriteAllText(path, "2");

            string data = File.ReadAllText(path).Trim();
            if (!double.TryParse(data, out double x))
                throw new FormatException("Fayl ichida son emas");

            double numerator = Math.Pow(x, 3) - 4 * x;
            double denominator = Math.Cos(x);

            if (Math.Abs(denominator) < 1e-10)
                throw new DivideByZeroException("cos(x) = 0");

            double result = numerator / denominator;
            return Math.Round(result, 3);
        }
    }
}
   

