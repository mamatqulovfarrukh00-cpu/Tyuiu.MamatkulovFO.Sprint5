using Tyuiu.MamatkulovFO.Sprint5.Task2.V14.Lib;
namespace Tyuiu.MamatkulovFO.Sprint5.Task2.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = {
                { -3, -6, -3 },
                { 6, 8, 3 },
                { -6, -5, 5 }
            };

            var service = new DataService();
            string filePath = service.SaveToFileTextData(matrix);

            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
