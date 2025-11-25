using Tyuiu.MamatkulovFO.Sprint5.Task5.V19.Lib;
using System;
using System.IO;

namespace Tyuiu.MamatkulovFO.Sprint5.Task5.V19
{
    class Program
    {
        static void Main()
        {
            string inputPath = @"C:\DataSprint5\InPutDataFileTask5V19.txt";

            // Если файла нет — создаём пример
            if (!File.Exists(inputPath))
                File.WriteAllText(inputPath, "16,15.24,9,8,11,19,-3,43,-6,9.4,20,11.67,1.72,12.7,10.45,-4,17.23,6.45,6.7,-7.58,-0.74");

            // Запускаем обработку
            DataService service = new DataService();
            double result = service.LoadFromDataFile(inputPath);

            // Выводим результат в консоль
            Console.WriteLine($"Разница между max и min однозначными целыми числами: {result:F3}");
            Console.ReadKey();
        }
    }
}