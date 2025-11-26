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
            string directoryPath = @"C:\DataSprint5";
            Directory.CreateDirectory(directoryPath);

            string filePath = Path.Combine(directoryPath, "InputDataFileTask5V19.txt");

            try
            {
                string content = File.ReadAllText(filePath);

                var numbers = content
                    .Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(s =>
                    {
                        if (double.TryParse(s.Trim(), out double value))
                            return (double?)value;
                        else
                            return null;
                    })
                    .Where(n => n.HasValue && n.Value > 0) // Faqat musbat sonlar
                    .Select(n => (int)Math.Floor(n.Value)) // Butun qismiga yaxlitlash
                    .ToList();

                if (numbers.Count == 0)
                {
                    Console.WriteLine("❌ В файле нет подходящих чисел.");
                    return;
                }

                int max = numbers.Max();
                int min = numbers.Min();

                double result = Math.Round((double)(max - min), 3);

                Console.WriteLine($"✅ Результат: {result:F3}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Ошибка: {ex.Message}");
            }

            Console.WriteLine("\nНажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}