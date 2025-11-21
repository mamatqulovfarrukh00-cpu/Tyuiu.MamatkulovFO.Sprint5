using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MamatkulovFO.Sprint5.Task4.V27.Lib
{
    public class DataService : ISprint5Task4V27
    {
        public double LoadFromDataFile(string path)
        {
            string data = File.ReadAllText(path);
            double x = double.Parse(data);

            double numerator = Math.Pow(x, 3) - 4 * x;
            double denominator = Math.Cos(x);

            if (Math.Abs(denominator) < 1e-10)
                throw new DivideByZeroException("cos(x) = 0");

            double result = numerator / denominator;
            return Math.Round(result, 3);
        }
    }
}
   

