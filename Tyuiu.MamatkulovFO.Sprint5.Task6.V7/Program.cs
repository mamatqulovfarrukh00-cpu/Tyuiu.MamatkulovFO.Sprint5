using Tyuiu.MamatkulovFO.Sprint5.Task6.V7.Lib;
using System.IO;

namespace Tyuiu.MamatkulovFO.Sprint5.Task6.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Кутулиган файл йўли (топшириқда берилган)
            string path = @"C:\DataSprint5\InputDataFileTask6V7.txt";

            // Агар файл мавжуд бўлмаса, ишлатиш учун вактничалик файл яратамиз
            if (!File.Exists(path))
            {
                path = Path.Combine(Path.GetTempPath(), "InputDataFileTask6V7.txt");
                File.WriteAllText(path, "Пример текста с ABC и 789!");
            }

            DataService ds = new DataService();
            int latinCount = ds.LoadFromDataFile(path);

            Console.WriteLine($"Количество латинских букв в первой строке: {latinCount}");
            Console.ReadKey();
        }
    }
}