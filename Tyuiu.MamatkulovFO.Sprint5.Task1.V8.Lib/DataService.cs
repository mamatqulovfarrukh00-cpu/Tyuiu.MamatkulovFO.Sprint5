using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MamatkulovFO.Sprint5.Task1.V8.Lib
{
    public class DataService : ISprint5Task1V8
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int x = startValue; x <= stopValue; x++)
                {
                    double denominator = 2 * x - 2;
                    if (Math.Abs(denominator) < 1e-10)
                    {
                        writer.WriteLine($"{x};0.00");
                    }
                    else
                    {
                        double result = 4 - 2 * x + (2 + Math.Cos(x)) / denominator;
                        writer.WriteLine($"{x};{result:F2}");
                    }
                }
            }
            return path;
        }

    }
}