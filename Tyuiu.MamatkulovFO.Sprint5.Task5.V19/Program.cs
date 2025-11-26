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
            string filePath = Path.Combine(directoryPath, "InputDataFileTask5V19.txt");

            // Papkani yaratish
            Directory.CreateDirectory(directoryPath);

            // Faylni yaratish va ma'lumot yozish (agar fayl mavjud bo'lmasa)
            if (!File.Exists(filePath))
            {
                string testData = "16 15.24 9 8 11 19 -3.43 -6 9.4 20 11.67 1.72 12.7 10.45 -4 17.23 6.45 6.7 -7.58 -0.74";
                File.WriteAllText(filePath, testData);
                Console.WriteLine("✅ Файл создан и заполнен тестовыми данными.");
            }

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
                    .Where(n => n.HasValue && n.Value > 0 && n.Value <= 16) // Faqat 1 dan 16 gacha musbat sonlar
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