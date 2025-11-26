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
            string content = File.ReadAllText(path);

            var numbers = content
                .Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(s => double.TryParse(s, out _)) // Faqat sonlarni o'tkaz
                .Select(s => double.Parse(s))
                .Where(n => n > 0) // Faqat musbat
                .Select(n => (int)Math.Floor(n)) // Butun qismiga yaxlitlash
                .Where(n => n <= 16) // 16 dan katta sonlarni o'tkazib yuborish
                .ToList();

            int max = numbers.Max();
            int min = numbers.Min();

            return Max.Round(max - min, 3);
        }
    }
}