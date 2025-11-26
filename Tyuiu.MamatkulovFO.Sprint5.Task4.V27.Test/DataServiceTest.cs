using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MamatkulovFO.Sprint5.Task4.V27.Lib;
namespace Tyuiu.MamatkulovFO.Sprint5.Task4.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var service = new DataService();
            string tempPath = Path.Combine(Path.GetTempPath(), "InPutDataFileTask4V27.txt");
            File.WriteAllText(tempPath, "-1.26");

            double result = service.LoadFromDataFile(tempPath); 

            Assert.AreEqual(1.985, result, 0.001);
        }
    }
}
