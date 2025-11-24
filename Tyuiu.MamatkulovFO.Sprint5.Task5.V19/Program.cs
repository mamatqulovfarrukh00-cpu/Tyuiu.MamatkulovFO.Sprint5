using System;
using Tyuiu.MamatkulovFO.Sprint5.Task5.V19.Lib;

namespace Tyuiu.MamatkulovFO.Sprint5.Task5.V19
{
    class Program
    {
        static void Main()
        {
            var service = new DataService();
            string path = @"C:\DataSprint5\InputDataFileTask5V19.txt";
            double result = service.LoadFromDataFile(path);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}