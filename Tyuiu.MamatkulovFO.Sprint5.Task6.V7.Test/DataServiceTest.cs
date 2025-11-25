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
            string tempFile = Path.GetTempFileName();
            // Фақат биринчи қаторни текширамиз
            File.WriteAllText(tempFile, "Hello, Мир! 123 ABC\nЭто вторая строка");

            DataService ds = new DataService();
            int result = ds.LoadFromDataFile(tempFile);

            // "Hello, Мир! 123 ABC" → H,e,l,l,o,A,B,C → 8 та лотин ҳарф
            Assert.AreEqual(8, result);

            File.Delete(tempFile);
        }
    }
}
