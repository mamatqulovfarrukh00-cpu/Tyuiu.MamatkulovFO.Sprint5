using Tyuiu.MamatkulovFO.Sprint5.Task4.V27.Lib;
namespace Tyuiu.MamatkulovFO.Sprint5.Task4.V27.Test
{ 
    public class DataServiceTest
    {
            [Fact]
            public void LoadFromDataFile_CorrectValue_ReturnsExpectedResult()
            {
                var service = new DataService();
                double result = service.LoadFromDataFile(@"C:\DataSprint5\InPutDataFileTask4V0.txt");
                Assert.IsTrue(double.IsFinite(result));
            }
    }
}
