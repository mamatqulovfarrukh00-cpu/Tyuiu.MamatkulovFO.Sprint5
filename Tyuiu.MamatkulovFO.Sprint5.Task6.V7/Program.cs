using Tyuiu.MamatkulovFO.Sprint5.Task6.V7.Lib;
using System.IO;

namespace Tyuiu.MamatkulovFO.Sprint5.Task6.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"/app/data/AssesmentData/C#/Sprint5Task6/InPutDataFileTask6V7.txt";

            // Агар файл мавжуд бўлмаса — вактничалик файл яратамиз (текшириш учун)
            if (!File.Exists(path))
            {
                path = Path.GetTempFileName();
                File.WriteAllText(path, "ABCDEFGHIJKLMNOP"); // 16 та лотин ҳарф
            }

            var ds = new DataService();
            int count = ds.LoadFromDataFile(path);

            Console.WriteLine($"Ответ: {count}"); // Консольда 16 чоп этилади
            Console.ReadKey();
        }
    }
}