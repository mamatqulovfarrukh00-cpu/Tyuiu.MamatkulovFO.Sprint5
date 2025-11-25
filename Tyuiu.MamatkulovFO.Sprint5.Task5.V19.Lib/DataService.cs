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
            // Читаем файл и разбиваем по запятым
            string content = File.ReadAllText(path);
            var numbers = content.Split(',')
                                .Select(s => double.Parse(s.Trim())) // Парсим как double
                                .Where(n => n >= 1 && n <= 9 && n == Math.Floor(n)) // Только однозначные целые (1-9)
                                .ToList();

            // Находим макс и мин
            int max = (int)numbers.Max();
            int min = (int)numbers.Min();

            // Возвращаем разницу, округлённую до 3 знаков
            return Math.Round((double)(max - min), 3);
        }
    }
}
