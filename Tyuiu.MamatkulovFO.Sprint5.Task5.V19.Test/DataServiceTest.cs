using System;
using System.IO;
using System.Linq;
using Tyuiu.MamatkulovFO.Sprint5.Task5.V19.Lib;
namespace Tyuiu.MamatkulovFO.Sprint5.Task5.V19
{
    class Program
    {
        static void Main()
        {
            string path = @"C:\DataSprint5\InputDataFileTask5V19.txt";
            Directory.CreateDirectory(@"C:\DataSprint5");

            try
            {
                var numbers = File.ReadAllText(path)
                    .Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => double.TryParse(s.Trim(), out double v) ? (double?)v : null)
                    .Where(n => n.HasValue)
                    .Select(n => n.Value)
                    .Where(n => n > 0) // Faqat musbat sonlar
                    .Select(n => (int)Math.Floor(n)) // Butun qismiga yaxlitlash
                    .ToList();

                if (numbers.Count == 0) return;

                int max = numbers.Max();
                int min = numbers.Min();

                Console.WriteLine($"Результат: {(max - min):F3}");
            }
            catch
            {
                Console.WriteLine("Ошибка при чтении файла.");
            }

            Console.ReadLine();
        }
    }
}