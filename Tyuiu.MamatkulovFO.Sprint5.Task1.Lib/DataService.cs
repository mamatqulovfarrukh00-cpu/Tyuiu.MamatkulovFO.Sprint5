using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MamatkulovFO.Sprint5.Task1.Lib
{
    public class DataService : ISprint5Task1V8
    {
        public string SaveToFileTextData(int start, int stop)
        {
            string file = Path.GetTempFileName();
            Console.WriteLine("x\tF(x)");
            for (int x = start; x <= stop; x++)
            {
                double denom = 2 - 2 * x; // ← ИСПРАВЛЕНА ФОРМУЛА
                double y = denom == 0 ? 0 : Math.Round(4 - 2 * x + (2 + Math.Cos(x)) / denom, 2);
                Console.WriteLine($"{x}\t{y}");
                File.AppendAllText(file, $"{x}\t{y}\n");
            }
            return file;
        }
    }

}

