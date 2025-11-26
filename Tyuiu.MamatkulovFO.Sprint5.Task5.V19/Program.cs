using System;
using System.IO;
using System.Linq;
using Tyuiu.MamatkulovFO.Sprint5.Task5.V19.Lib;

namespace Tyuiu.MamatkulovFO.Sprint5.Task5.V19
{
    class Program
    {
        static void Main()
        {
            string directoryPath = @"C:\DataSprint5";
            Directory.CreateDirectory(directoryPath);
            string filePath = Path.Combine(directoryPath, "InputDataFileTask5V19.txt");

            try
            {
                var service = new DataService();
                double result = service.LoadFromDataFile(filePath);
                Console.WriteLine($"Результат: {result:F3}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}