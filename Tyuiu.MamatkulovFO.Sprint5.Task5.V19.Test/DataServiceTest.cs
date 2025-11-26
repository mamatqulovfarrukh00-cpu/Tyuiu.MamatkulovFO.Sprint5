using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.MamatkulovFO.Sprint5.Task5.V19.Lib;

namespace Tyuiu.MamatkulovFO.Sprint5.Task5.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Создаем временный файл для тестирования
            string tempFilePath = Path.GetTempFileName();
            File.WriteAllText(tempFilePath, "1.0 2.0 3.5 4.0 5.0 6.0 7.0 8.0 9.0");

            var service = new DataService();
            double result = service.LoadFromDataFile(tempFilePath);

            // Ожидаемый результат: 9 - 1 = 8.000
            Assert.AreEqual(8.0, result, 0.001);

            // Удаляем временный файл
            File.Delete(tempFilePath);
        }

        // Для ручного запуска (если требуется)
        public static void Main()
        {
            try
            {
                string directoryPath = @"C:\DataSprint5";
                Directory.CreateDirectory(directoryPath);
                string filePath = Path.Combine(directoryPath, "InputDataFileTask5V19.txt");

                var service = new DataService();
                double result = service.LoadFromDataFile(filePath);

                Console.WriteLine($"✅ Результат: {result:F3}");
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