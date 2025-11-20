using Tyuiu.MamatkulovFO.Sprint5.Task1.V8.Lib;
namespace Tyuiu.MamatkulovFO.Sprint5.Task1.V8.Test
{
    [TestClass]
   
    
        public class DataServiceTest
        {
            [Test]
            public void TestSaveToFileTextData()
            {
                DataService ds = new DataService();
                string result = ds.SaveToFileTextData(-5, 5);
                Assert.IsTrue(File.Exists(result));
            }
        }
    
}
