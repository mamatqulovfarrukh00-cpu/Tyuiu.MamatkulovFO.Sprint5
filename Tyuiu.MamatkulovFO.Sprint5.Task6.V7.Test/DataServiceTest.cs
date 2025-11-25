using Tyuiu.MamatkulovFO.Sprint5.Task6.V7.Lib;
namespace Tyuiu.MamatkulovFO.Sprint5.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFileTest()
        {
            // Создаём временный файл с тестовыми данными
            string tempFile = Path.GetTempFileName();
            File.WriteAllText(tempFile, "Hello, Мир! 123 ABC xyz");

            DataService ds = new DataService();
            int result = ds.LoadFromDataFile(tempFile);

            // В строке: H,e,l,l,o, A,B,C, x,y,z → 11 латинских букв
            Assert.AreEqual(11, result);

            // Удаляем временный файл
            File.Delete(tempFile);
        }
    }
}
