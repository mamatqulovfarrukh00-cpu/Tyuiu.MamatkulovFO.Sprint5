using Tyuiu.MamatkulovFO.Sprint5.Task2.V14.Lib;
namespace Tyuiu.MamatkulovFO.Sprint5.Task2.V14.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void SaveToFileTextData_ReplacePosNeg_ReturnsCorrectCsv()
        {
            var service = new DataService();
            int[,] matrix = {
                { -3, -6, -3 },
                { 6, 8, 3 },
                { -6, -5, 5 }
            };

            string path = service.SaveToFileTextData(matrix);
            string[] lines = File.ReadAllLines(path);

            Assert.AreEqual("0;0;0", lines[0]);
            Assert.AreEqual("1;1;1", lines[1]);
            Assert.AreEqual("0;0;1", lines[2]);
        }
    }
}
