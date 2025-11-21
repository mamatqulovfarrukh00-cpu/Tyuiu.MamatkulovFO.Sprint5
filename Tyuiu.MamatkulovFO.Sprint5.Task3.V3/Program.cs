using Tyuiu.MamatkulovFO.Sprint5.Task3.V3.Lib;
namespace Tyuiu.MamatkulovFO.Sprint5.Task3.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new DataService();
            string filePath = service.SaveToFileTextData(3);

            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                double result = reader.ReadDouble();
                Console.WriteLine($"Результат: {result:F3}");
            }
        }
    }
}
