using System;
using System.IO;
using Tyuiu.MamatkulovFO.Sprint5.Task5.V19.Lib;

namespace Tyuiu.MamatkulovFO.Sprint5.Task5.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string directoryPath = @"C:\DataSprint5";
                string fileName = "InputDataFileTask5V19.txt";
                string filePath = Path.Combine(directoryPath, fileName);

                // Проверяем, существует ли файл
                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"Ошибка: файл не найден по пути {filePath}.");
                    Console.WriteLine("Пожалуйста, поместите файл в папку C:\\DataSprint5.");
                    return;
                }

                // Обрабатываем данные из файла
                DataService ds = new DataService();
                double result = ds.LoadFromDataFile(filePath);

                // Выводим результат с тремя знаками после запятой
                Console.WriteLine($"{result:F3}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}