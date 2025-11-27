using System;
using System.IO;

using Tyuiu.MamatkulovFO.Sprint5.Task5.V19.Lib;

namespace Tyuiu.MamatkulovFO.Sprint5.Task4.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string directoryPath = @"C:\DataSprint5";
                string fileName = "InPutDataFileTask4V27.txt";
                string filePath = Path.Combine(directoryPath, fileName);

                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"Ошибка: файл {filePath} не найден.");
                    Console.WriteLine("Пожалуйста, поместите файл в папку C:\\DataSprint5.");
                    return;
                }

                var service = new DataService();
                double result = service.LoadFromDataFile(filePath);

                Console.WriteLine($"{result:F3}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}