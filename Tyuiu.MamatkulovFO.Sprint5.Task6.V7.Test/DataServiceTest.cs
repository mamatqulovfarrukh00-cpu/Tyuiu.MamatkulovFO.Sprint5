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
            // Биринчи қаторда 16 та лотин ҳарф бўлишини имитация қиламиз
            File.WriteAllText(tempFile, "This is test line with 16 letters ABCDEFGHIJKLMNOP\nSecond line");

            DataService ds = new DataService();
            int result = ds.LoadFromDataFile(tempFile);

            Assert.AreEqual(16, result); // КУТИЛГАН ЖАВОБ

            File.Delete(tempFile);
        }
    }
}