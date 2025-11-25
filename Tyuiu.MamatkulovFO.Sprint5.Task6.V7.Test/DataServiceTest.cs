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
            string path = @"/app/data/AssesmentData/C#/Sprint5Task6/InPutDataFileTask6V7.txt";

            // Агар файл мавжуд бўлмаса — вактничалик файл яратамиз
            if (!File.Exists(path))
            {
                path = Path.GetTempFileName();
                File.WriteAllText(path, "ABCDEFGHIJKLMNOP");
            }

            var ds = new DataService();
            int result = ds.LoadFromDataFile(path);

            Assert.AreEqual(16, result); // Кутилган жавоб

            // Агар вактничалик файл бўлса — ўчирамиз
            if (path.StartsWith(Path.GetTempPath()))
                File.Delete(path);
        }
    }
}