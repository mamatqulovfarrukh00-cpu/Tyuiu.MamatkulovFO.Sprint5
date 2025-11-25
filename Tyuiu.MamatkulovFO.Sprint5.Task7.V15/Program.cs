using Tyuiu.MamatkulovFO.Sprint5.Task7.V15.Lib;
using System;
using System.IO;

namespace Tyuiu.MamatkulovFO.Sprint5.Task7.V15
{
    class Program
    {
        static void Main()
        {
            string input = @"C:\DataSprint5\InPutDataFileTask7V15.txt";

            // Если файла нет — создаём пример
            if (!File.Exists(input))
                File.WriteAllText(input, "This is just a sample строки in English .");

            // Запускаем обработку
            var service = new DataService();
            string output = service.LoadDataAndSave(input);

            // Выводим результат
            Console.WriteLine(File.ReadAllText(output));
        }
    }
}