using Tyuiu.MamatkulovFO.Sprint5.Task1.V8.Lib;
namespace Tyuiu.MamatkulovFO.Sprint5.Task1.V8
{
    /// <summary>
    /// Главный класс программы.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисление функции F(x) = 4 - 2x + (2 + cos(x)) / (2x - 2)");
            Console.WriteLine("на отрезке [-5; 5] с шагом 1.\n");

            // Создаём экземпляр сервиса
            var service = new DataService();

            // Выполняем расчёт и получаем путь к файлу
            string fileName = service.SaveToFileTextData(-5, 5);

            // Выводим содержимое файла в консоль
            string[] lines = System.IO.File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine($"\n📁 Результат сохранён в файл: {fileName}");

            // Запускаем тест
            Console.WriteLine("\n🧪 Запуск теста...");
            DataServiceTest.RunTest();

            Console.WriteLine("\nНажмите любую клавишу для завершения...");
            Console.ReadKey();
        }
    }
}