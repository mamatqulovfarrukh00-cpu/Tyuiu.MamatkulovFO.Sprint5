using Tyuiu.MamatkulovFO.Sprint5.Task1.V8.Lib;
namespace Tyuiu.MamatkulovFO.Sprint5.Task1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        public static void RunTest()
        {
            var service = new DataService();
            string path = service.SaveToFileTextData(-5, 5);

            if (File.Exists(path))
            {
                var lines = File.ReadAllLines(path);
                bool hasHeader = lines[0].Contains("x") && lines[0].Contains("F(x)");
                bool hasData = lines.Length > 5;

               
            }
            else
            {
                
            }
        }
    }
}
