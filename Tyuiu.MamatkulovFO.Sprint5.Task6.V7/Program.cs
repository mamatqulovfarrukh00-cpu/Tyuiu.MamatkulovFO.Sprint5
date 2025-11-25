using Tyuiu.MamatkulovFO.Sprint5.Task6.V7.Lib;
using System.IO;

namespace Tyuiu.MamatkulovFO.Sprint5.Task6.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\DataSprint5\InputDataFileTask6V7.txt";

            // Агар файл мавжуд бўлмаса, вактничалик файл яратамиз (текшириш учун)
            if (!File.Exists(path))
            {
                path = Path.Combine(Path.GetTempPath(), "InputDataFileTask6V7.txt");
                File.WriteAllText(path, "This is test line with 16 letters ABCDEFGHIJKLMNOP");
            }

            DataService ds = new DataService();
            int latinCount = ds.LoadFromDataFile(path);

            Console.WriteLine($"Количество латинских букв в первой строке: {latinCount}");
            Console.ReadKey();
        }
    }
}