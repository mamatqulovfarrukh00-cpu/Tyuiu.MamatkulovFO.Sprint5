using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MamatkulovFO.Sprint5.Task5.V19.Lib;

namespace Tyuiu.MamatkulovFO.Sprint5.Task5.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
           
            string tempFile = Path.GetTempFileName();
            File.WriteAllText(tempFile, "16, 15.24, 9, 8, 11, 19, -3.43, -6, 9.4, 20, 11.67, 1.72");

            var service = new DataService();
            double result = service.LoadFromDataFile(tempFile);

            
            Assert.AreEqual(1.0, result);

           
            File.Delete(tempFile);
        }
    }
}