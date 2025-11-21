using Tyuiu.MamatkulovFO.Sprint5.Task4.V27.Lib;
namespace Tyuiu.MamatkulovFO.Sprint5.Task4.V27.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void LoadFromDataFile_CreatesFileIfNotExists_ReturnsCorrectValue()
        {
            var service = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask4V0.txt";
            double result = service.LoadFromDataFile(path);
            Assert.IsTrue(double.IsFinite(result));
        }
    }
}
