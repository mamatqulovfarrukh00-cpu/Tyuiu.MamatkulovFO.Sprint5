using Tyuiu.MamatkulovFO.Sprint5.Task6.V7.Lib;
using System.IO;

namespace Tyuiu.MamatkulovFO.Sprint5.Task6.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            string folder = @"C:\DataSprint5";
            string fileName = "InputDataFileTask6V7.txt";
            string path = Path.Combine(folder, fileName);

           
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

           
            if (!File.Exists(path))
            {
               
                File.WriteAllText(path, "ABCDEFGHIJKLMNO\nIkkinchi qator — bu e'tiborsiz");
            }

            DataService ds = new DataService();
            int count = ds.LoadFromDataFile(path);

            Console.WriteLine($"Ответь: {count}"); 
            Console.ReadKey();
        }
    }
}