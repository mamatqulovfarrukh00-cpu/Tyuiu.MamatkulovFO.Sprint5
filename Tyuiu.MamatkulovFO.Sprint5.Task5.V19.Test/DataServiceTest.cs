using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.MamatkulovFO.Sprint5.Task5.V19.Lib;

namespace Tyuiu.MamatkulovFO.Sprint5.Task4.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string tempPath = Path.GetTempFileName();
            File.WriteAllText(tempPath, "-1.26");

            var service = new DataService();
            double result = service.LoadFromDataFile(tempPath);

            Assert.AreEqual(-1.26, result, 0.001);

            File.Delete(tempPath);
        }

        public static void Main()
        {
            try
            {
                string directoryPath = @"C:\DataSprint5";
                Directory.CreateDirectory(directoryPath);
                string filePath = Path.Combine(directoryPath, "InPutDataFileTask4V27.txt");

                var service = new DataService();
                double result = service.LoadFromDataFile(filePath);

                Console.WriteLine($"Результат: {result:F3}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}