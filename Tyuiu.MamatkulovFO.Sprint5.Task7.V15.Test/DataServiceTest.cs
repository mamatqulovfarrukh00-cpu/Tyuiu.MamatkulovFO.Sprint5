using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MamatkulovFO.Sprint5.Task7.V15.Lib;
using System.IO;

namespace Tyuiu.MamatkulovFO.Sprint5.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadDataAndSave_ValidInput_RemovesTwoLetterWords()
        {
            // Подготавливаем тестовый входной файл
            string inputPath = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V15.txt");
            File.WriteAllText(inputPath, "This is just a sample строки in English .");

            // Вызываем метод
            DataService service = new DataService();
            string outputPath = service.LoadDataAndSave(inputPath);

            // Проверяем результат
            string result = File.ReadAllText(outputPath).Trim();
            Assert.AreEqual("This just sample строки English .", result);

            // Очищаем временные файлы
            File.Delete(inputPath);
            File.Delete(outputPath);
        }
    }
}
