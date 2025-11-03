using Tyuiu.MamatkulovFO.Sprint5.Task0.V13.Lib;
namespace Tyuiu.MamatkulovFO.Sprint5.Task0.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData_WithXEquals5_ReturnsCorrectFilePathAndWritesCorrectValue()
        {
            // Подготавливаем
            var service = new DataService();
            int x = 5;
            string expectedValue = "-114.500"; // F(5) = -114.5 → с тремя знаками после запятой

            // Выполняем
            string filePath = service.SaveToFileTextData(x);

            // Проверяем
            Assert.IsTrue(File.Exists(filePath), "Файл не был создан!");

            string actualContent = File.ReadAllText(filePath).Trim();
            Assert.AreEqual(expectedValue, actualContent, "Содержимое файла не совпадает с ожидаемым!");

            // Очистка (удаляем временный файл после теста)
            File.Delete(filePath);
        }
    }
}
