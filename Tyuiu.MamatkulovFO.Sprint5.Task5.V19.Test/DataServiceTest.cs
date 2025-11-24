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
                var service = new DataService();
                string path = Path.Combine(Path.GetTempPath(), "InputDataFileTask5V19.txt");
                double result = service.LoadFromDataFile(path);
                Assert.AreEqual(8.0, result); // masalan, agar 1 va 9 bor bo'lsa
            }
        
       
       
          
    }
}