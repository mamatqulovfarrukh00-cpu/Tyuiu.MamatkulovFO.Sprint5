using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MamatkulovFO.Sprint5.Task5.V19.Lib
{
    public class DataService : ISprint5Task5V19
    {
        public double LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"Файл не найден: {path}");

            var lines = File.ReadAllLines(path);
            var singleDigitIntegers = new List<int>();

            foreach (var line in lines)
            {
                var parts = line.Split(new char[] { ' ', '\t', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var part in parts)
                {
                    if (int.TryParse(part.Trim(), out int number))
                    {
                        // Фильтр: только однозначные целые числа (-9 <= x <= 9)
                        if (number >= -9 && number <= 9)
                        {
                            singleDigitIntegers.Add(number);
                        }
                    }
                }
            }

            if (singleDigitIntegers.Count == 0)
                throw new InvalidOperationException("В файле нет однозначных целых чисел.");

            int max = singleDigitIntegers.Max();
            int min = singleDigitIntegers.Min();

            return Math.Round(max - min, 3); // Округляем до 3 знаков
        }
    }
}

