using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MamatkulovFO.Sprint5.Task5.V19.Lib;
using System.IO;

namespace Tyuiu.MamatkulovFO.Sprint5.Task5.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile_ValidInput_ReturnsCorrectDifference()
        {
            // Подготавливаем тестовый файл
            string inputPath = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V19.txt");
            File.WriteAllText(inputPath, "16,15.24,9,8,11,19,-3,43,-6,9.4,20,11.67,1.72,12.7,10.45,-4,17.23,6.45,6.7,-7.58,-0.74");

            // Вызываем метод
            DataService service = new DataService();
            double result = service.LoadFromDataFile(inputPath);

            // Проверяем результат: из чисел 9,8,6 → max=9, min=6 → разница=3.0
            Assert.AreEqual(3.0, result);

            // Удаляем временный файл
            File.Delete(inputPath);
        }
    }
}