using Tyuiu.MamatkulovFO.Sprint5.Task6.V7.Lib;
namespace Tyuiu.MamatkulovFO.Sprint5.Task6.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаём временный файл для демонстрации
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask6V7.txt");
            File.WriteAllText(path, "Пример текста с ABC и 789!");

            // Выполняем задачу
            DataService ds = new DataService();
            int latinCount = ds.LoadFromDataFile(path);

            // Выводим результат
            Console.WriteLine($"Количество латинских букв: {latinCount}");
            Console.ReadKey(); // Ждём нажатия клавиши
        }
    }
}
