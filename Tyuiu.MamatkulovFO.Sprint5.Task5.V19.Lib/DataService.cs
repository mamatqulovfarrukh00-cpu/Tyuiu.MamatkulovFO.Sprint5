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
                var numbers = File.ReadAllText(path)
                                  .Split(',')
                                  .Select(s => int.Parse(s.Trim()))
                                  .Where(n => n > 0) // однозначные: от 1 до 9
                                  .ToList();

                int max = numbers.Max();
                int min = numbers.Min();

                return Math.Round((double)(max - min), 3);
            }
        }
}

