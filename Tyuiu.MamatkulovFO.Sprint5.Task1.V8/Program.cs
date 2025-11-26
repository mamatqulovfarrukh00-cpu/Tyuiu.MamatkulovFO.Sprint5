using System;
using Tyuiu.MamatkulovFO.Sprint5.Task1.V8.Lib;

namespace Tyuiu.MamatkulovFO.Sprint5.Task1.V8
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Табулирование функции F(x) на интервале [-5; 5]");
            Console.WriteLine("--------------------------------------------------");

            var service = new DataService();
            string path = service.SaveToFileTextData(-5, 5);

            
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Результат сохранен в файл. Нажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}