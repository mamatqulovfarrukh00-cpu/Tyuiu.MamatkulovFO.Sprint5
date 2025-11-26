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
           
            string tempPath = Path.GetTempFileName();
            File.WriteAllText(tempPath, "16 15.24 9 8 11 19 -3.43 -6 9.4 20 11.67 1.72 12.7 10.45 -4 17.23 6.45 6.7 -7.58 -0.74");

            var service = new DataService();
            double result = service.LoadFromDataFile(tempPath);

         
            Assert.AreEqual(15.0, result, 0.001);

           
            File.Delete(tempPath);
        }

       
        public static void Main()
        {
            try
            {
                string directoryPath = @"C:\DataSprint5";
                Directory.CreateDirectory(directoryPath);
                string filePath = Path.Combine(directoryPath, "InputDataFileTask5V19.txt");

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