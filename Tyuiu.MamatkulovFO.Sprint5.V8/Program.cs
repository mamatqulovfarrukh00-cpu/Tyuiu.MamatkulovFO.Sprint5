using Tyuiu.MamatkulovFO.Sprint5.Task1.V8.Lib;
namespace Tyuiu.MamatkulovFO.Sprint5.Task1.V8;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Sprint5 Task1 V8");
        DataService ds = new DataService();
        string filePath = ds.SaveToFileTextData(-5, 5);

        Console.WriteLine("x | f(x)");
        Console.WriteLine("---|------");
        foreach (string line in File.ReadLines(filePath))
        {
         
        }

        Console.WriteLine($"\nFile saved: {filePath}");
        Console.ReadKey();
    }
}