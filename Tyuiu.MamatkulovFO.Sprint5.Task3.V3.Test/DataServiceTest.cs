using Tyuiu.MamatkulovFO.Sprint5.Task3.V3.Lib;
namespace Tyuiu.MamatkulovFO.Sprint5.Task3.V3.Test
{
    public class DataServiceTest
    {
        private double duoble;

        [Fact]
        public void SaveToFileTextData_CorrectValueForX3_Returns7_348()
        {
            var service = new DataService();
            string path = service.SaveToFileTextData(3);

            Assert.IsTrue(File.Exists(path));

            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                double value = reader.ReadDouble();
                duoble = reader.ReadDouble();
            }
        }
    }
}