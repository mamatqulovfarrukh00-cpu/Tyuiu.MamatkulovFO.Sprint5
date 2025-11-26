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
            // Создаем директорию C:\DataSprint5, если она не существует
            string directoryPath = @"C:\DataSprint5";
            Directory.CreateDirectory(directoryPath);

            // Указываем полный путь к входному файлу
            string filePath = Path.Combine(directoryPath, "InputDataFileTask5V19.txt");

            try
            {
                // Читаем содержимое файла
                string content = File.ReadAllText(filePath);

                // Разбиваем строку на отдельные значения, удаляем пустые элементы
                var numbers = content
                    .Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(s =>
                    {
                        if (double.TryParse(s.Trim(), out double value))
                            return (double?)value;
                        else
                            return null;
                    })
                    .Where(n => n.HasValue)
                    .Select(n => n.Value)
                    .Where(n => n > 0) // Только положительные числа
                    .Select(n => (int)Math.Round(n)) // Округляем до ближайшего целого
                    .ToList();

                // Проверяем, есть ли подходящие числа
                if (numbers.Count == 0)
                {
                    Console.WriteLine("❌ В файле нет положительных чисел.");
                    return;
                }

                // Находим максимальное и минимальное значение
                int max = numbers.Max();
                int min = numbers.Min();

                // Вычисляем разницу и округляем до трёх знаков после запятой
                double result = Math.Round((double)(max - min), 3);

                // Выводим результат в консоль
                Console.WriteLine($"✅ Результат: {result:F3}");

                // Завершаем работу программы
                Console.WriteLine("\nНажмите Enter для выхода...");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                // Обрабатываем возможные ошибки
                Console.WriteLine($"❌ Ошибка: {ex.Message}");
                Console.WriteLine("\nНажмите Enter для выхода...");
                Console.ReadLine();
            }
        }
    }
}