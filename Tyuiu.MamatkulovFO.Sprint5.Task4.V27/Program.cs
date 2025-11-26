using System;
using Tyuiu.MamatkulovFO.Sprint5.Task4.V27.Lib;

namespace Tyuiu.MamatkulovFO.Sprint5.Task4.V27
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Формула: y = (x^3 - 4x) / cos(x)");
            Console.WriteLine("--------------------------------------------------");

           
            string filePath = @"C:\DataSprint5\InPutDataFileTask4V27.txt";

           
            Directory.CreateDirectory(@"C:\DataSprint5");

          
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "-1.26");
            }

            var service = new DataService();
            double result = service.CalculateFormulaFromDataFile(filePath);

            Console.WriteLine($"Результат: {result:F3}");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Нажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}
