using System;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MamatkulovFO.Sprint5.Task5.V19.Lib
{
    public class DataService:ISprint5Task5V19
    {
        public double LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Файл не найден", path);

            string content = File.ReadAllText(path);

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
                .Where(n => n > 0) // Faqat musbat sonlar
                .Select(n => (int)Math.Floor(n)) // Butun qismiga yaxlitlash
                .ToList();

            if (numbers.Count == 0)
                throw new InvalidOperationException("В файле нет подходящих чисел.");

            int max = numbers.Max();
            int min = numbers.Min();

            return Math.Round((double)(max - min), 3);
        }
    }
}