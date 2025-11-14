using Tyuiu.MamatkulovFO.Sprint5.Task1.Lib;
namespace Tyuiu.MamatkulovFO.Sprint5.Task1.Test
{
    public class DataServiceTests
    {
        [Fact]
        public void SaveToFileTextData_ReturnsCorrectValue()
        {
            var service = new DataService();
            string path = service.SaveToFileTextData(-5, -5);
            string line = File.ReadLines(path).First();
            double actual = double.Parse(line.Split('\t')[1]);
            double expected = Math.Round(4 - 2 * (-5) + (2 + Math.Cos(-5)) / (2 - 2 * (-5)), 2);
            Assert.AreEqual(expected, actual, 2);
        }
    }
}

