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
            string folder = @"C:\DataSprint5";
            string path = Path.Combine(folder, "InputDataFileTask6V7.txt");

            if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);
            if (!File.Exists(path))
                File.WriteAllText(path, "ABCDEFGHIJKLMNOP\nIkkinchi qator");

            var ds = new DataService();
            int result = ds.LoadFromDataFile(path);

            Assert.AreEqual(16, result); 
        }
    }
}
