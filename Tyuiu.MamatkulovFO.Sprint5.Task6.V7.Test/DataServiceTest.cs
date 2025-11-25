// <summary>
// Тест для проверки корректности работы метода LoadFromDataFile.
// </summary>
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MamatkulovFO.Sprint5.Task6.V7.Lib;
using System.IO;

namespace Tyuiu.MamatkulovFO.Sprint5.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFileTest()
        {
            // Создаём временный файл с ТОЧНЫМ содержимым из задания
            string tempFile = Path.GetTempFileName();
            File.WriteAllText(tempFile, "Hello, Мир! Это Is My First Program.");

            // Выполняем метод
            DataService ds = new DataService();
            int result = ds.LoadFromDataFile(tempFile);

            // Ожидаем 16 строчных латинских букв: e, l, l, o, s, y, i, r, s, t, r, o, g, r, a, m
            Assert.AreEqual(16, result);

            // Удаляем временный файл
            File.Delete(tempFile);
        }
    }
}