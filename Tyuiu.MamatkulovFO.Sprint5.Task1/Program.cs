using Tyuiu.MamatkulovFO.Sprint5.Task1.Lib;
namespace Tyuiu.MamatkulovFO.Sprint5.Task1
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Title = "Sprint 5 | Task 1 | V8 | Mamatkulov F.O.";

                DataService service = new DataService();

                // Заданный диапазон: от -5 до 5 с шагом 1
                int start = -5;
                int stop = 5;

                Console.WriteLine("Таблица значений функции F(x):");
                Console.WriteLine("-------------------------------------");

                // Вызываем метод для записи данных в файл и вывода в консоль
                string filePath = service.SaveToFileTextData(start, stop);

                Console.WriteLine($"\nРезультат сохранён в файл: {filePath}");
                Console.WriteLine("\nНажмите любую клавишу для выхода...");
                Console.ReadKey();
        }
    }
}
