using System;         
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string path = @"C:\DataSprint5\InputDataFileTask5V19.txt";
        Directory.CreateDirectory(@"C:\DataSprint5");

        var nums = File.ReadAllText(path)
                      .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                      .Where(s => double.TryParse(s, out double v) && v >= 1 && v <= 9 && v == (int)v)
                      .Select(int.Parse)
                      .ToList();

        if (nums.Count == 0)
        {
            Console.WriteLine("❌ Нет подходящих чисел.");
            return;
        }

       
      
    }
}