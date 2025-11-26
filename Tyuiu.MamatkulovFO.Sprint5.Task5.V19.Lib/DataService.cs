using System;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MamatkulovFO.Sprint5.Task5.V19.Lib
{
    public class DataService:ISprint5Task5V19
    {
        /// <summary>
        /// Загружает данные из файла, находит разницу между максимальным и минимальным однозначными целыми числами.
        /// </summary>
        /// <param name="path">Путь к файлу с данными</param>
        /// <returns>Разница между максимумом и минимумом, округлённая до трёх знаков после запятой</returns>
        public double LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Файл не найден", path);

            string content = File.ReadAllText(path);

            var numbers = content
                .Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => double.Parse(s.Trim()))
                .Where(n => n >= 1 && n <= 9 && Math.Abs(n - Math.Floor(n)) < 1e-10)
                .Select(n => (int)n)
                .ToList();

            if (numbers.Count == 0)
                throw new InvalidOperationException("В файле нет подходящих однозначных целых чисел.");

            int max = numbers.Max();
            int min = numbers.Min();

            return Math.Round((double)(max - min), 3);
        }
    }
}
