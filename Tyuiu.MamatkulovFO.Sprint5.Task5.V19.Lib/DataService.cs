using System;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MamatkulovFO.Sprint5.Task5.V19.Lib
{
    public class DataService : ISprint5Task5V19
    {
        public double LoadFromDataFile(string path)
        {
            // Читаем файл
            string content = File.ReadAllText(path);

            // Разбиваем по пробелам, убираем пустые
            var numbers = content
                .Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => double.Parse(s.Trim())) // Парсим как double
                .Where(n => n >= 1 && n <= 9 && Math.Abs(n - Math.Floor(n)) < 1e-10) // Целые от 1 до 9
                .Select(n => (int)n) // Приводим к int
                .ToList();

            // Находим макс и мин
            int max = numbers.Max();
            int min = numbers.Min();

            // Возвращаем разницу, округлённую до 3 знаков
            return Math.Round((double)(max - min), 3);
        }
    }
}