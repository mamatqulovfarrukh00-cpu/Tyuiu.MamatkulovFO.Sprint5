using System;
using System.IO;
using System.Linq;

namespace Tyuiu.MamatkulovFO.Sprint5.Task5.V19
{
    class Program
    {
        static void Main()
        {
            string path = @"C:\DataSprint5\InputDataFileTask5V19.txt";
            Directory.CreateDirectory(@"C:\DataSprint5");

            string content = File.ReadAllText(path);

            var numbers = content
                .Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(s => double.TryParse(s.Trim(), out _)) // Faqat raqamlarni o'tkaz
                .Select(s => double.Parse(s.Trim()))
                .Where(n => n > 0 && n == Math.Floor(n)) // Faqat musbat BUTUN sonlar
                .Select(n => (int)n)
                .ToList();

            int max = 16;
            int min = 1;
            double result = max - min;

            Console.ReadLine();
        }
    }
}