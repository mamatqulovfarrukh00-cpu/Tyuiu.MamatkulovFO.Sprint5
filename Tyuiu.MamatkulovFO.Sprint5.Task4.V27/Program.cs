using Tyuiu.MamatkulovFO.Sprint5.Task4.V27.Lib;
namespace Tyuiu.MamatkulovFO.Sprint5.Task4.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new DataService();
            double result = service.LoadFromDataFile(@"C:\DataSprint5\InPutDataFileTask4V0.txt");
            Console.WriteLine(result.ToString("F3"));
        }
    }
}
