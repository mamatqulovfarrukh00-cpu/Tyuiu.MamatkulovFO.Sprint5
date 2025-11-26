using System;
using System.IO;

using Tyuiu.MamatkulovFO.Sprint5.Task5.V19.Lib;

namespace Tyuiu.MamatkulovFO.Sprint5.Task5.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        public static void Main()
        {
            try
            {
                // Создаём папку
                Directory.CreateDirectory(@"C:\DataSprint5");

                // Указываем путь к файлу
                string filePath = @"C:\DataSprint5\InputDataFileTask5V19.txt";

                // Создаём объект сервиса
                var service = new DataService();

                // Выполняем метод
                double result = service.LoadFromDataFile(filePath);

                // Выводим результат
                Console.WriteLine($"Результат: {result:F3}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Ошибка: {ex.Message}");
            }

            Console.WriteLine("\nНажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}

