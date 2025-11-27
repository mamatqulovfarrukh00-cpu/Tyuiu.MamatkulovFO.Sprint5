using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MamatkulovFO.Sprint5.Task5.V19.Lib
{
    public class DataService:ISprint5Task5V19
    {
        public double LoadFromDataFile(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"Файл не найден: {filePath}");

            var lines = File.ReadAllLines(filePath);
            var singleDigitIntegers = new List<int>();

            foreach (var line in lines)
            {
                var parts = line.Split(new char[] { ' ', '\t', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var part in parts)
                {
                    if (int.TryParse(part.Trim(), out int number))
                    {
                        // Проверяем, является ли число однозначным целым (-9 <= x <= 9)
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

            return Math.Round(max - min, 3); // Разница как double, округляем до 3 знаков
        }
    }
}