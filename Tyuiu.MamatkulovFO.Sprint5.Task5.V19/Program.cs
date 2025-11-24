using System;
using Tyuiu.MamatkulovFO.Sprint5.Task5.V19.Lib;

namespace Tyuiu.MamatkulovFO.Sprint5.Task5.V19
{
    class Program
    {
        static void Main()
        {
            var service = new DataService();

            // Fayl yo'lini Path.Combine() yordamida tuzamiz
            string folder = @"C:\DataSprint5";
            string fileName = "InputDataFileTask5V19.txt";
            string path = Path.Combine(folder, fileName);

            // Agar papka mavjud emas bo'lsa, yaratamiz
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            double result = service.LoadFromDataFile(path);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}