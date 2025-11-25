// <summary>
// Главная программа для запуска и проверки результата.
// </summary>
using Tyuiu.MamatkulovFO.Sprint5.Task6.V7.Lib;
using System;
using System.IO;

namespace Tyuiu.MamatkulovFO.Sprint5.Task6.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Путь строго по заданию: папка + имя файла с "InPut" (P заглавная!)
            string path = @"C:\DataSprint5\InPutDataFileTask6V7.txt";

            // Проверяем, существует ли файл
            if (!File.Exists(path))
            {
                Console.WriteLine("Ошибка: Файл не найден по пути C:\\DataSprint5\\InPutDataFileTask6V7.txt");
                Console.WriteLine("Создайте папку C:\\DataSprint5 и поместите туда файл InPutDataFileTask6V7.txt");
                Console.ReadKey();
                return;
            }

            // Выполняем задачу
            DataService ds = new DataService();
            int result = ds.LoadFromDataFile(path);

            // Выводим результат
            Console.WriteLine($"Ответ: {result}");
            Console.ReadKey();
        }
    }
}