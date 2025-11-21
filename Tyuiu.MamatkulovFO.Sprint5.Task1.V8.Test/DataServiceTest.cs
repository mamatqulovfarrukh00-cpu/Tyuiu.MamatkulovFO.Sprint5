using Tyuiu.MamatkulovFO.Sprint5.Task1.V8.Lib;
namespace Tyuiu.MamatkulovFO.Sprint5.Task1.V8.Test
{
    /// <summary>
    /// Класс для проверки работы DataService.
    /// </summary>
    public class DataServiceTest
    {
        /// <summary>
        /// Выполняет базовый тест: проверяет, создан ли файл и содержит ли данные.
        /// </summary>
        public static void RunTest()
        {
            var service = new DataService();
            string path = service.SaveToFileTextData(-5, 5);

            if (File.Exists(path))
            {
                var lines = File.ReadAllLines(path);
                bool hasHeader = lines.Length > 0 && lines[0].Contains("x") && lines[0].Contains("F(x)");
                bool hasEnoughData = lines.Length >= 12; // 11 точек + заголовок + разделитель

                Console.WriteLine("✅ Тест пройден успешно:");
                Console.WriteLine($"- Файл существует: {path}");
                Console.WriteLine($"- Заголовок найден: {hasHeader}");
                Console.WriteLine($"- Количество строк: {lines.Length}");
            }
            else
            {
                Console.WriteLine("❌ ОШИБКА: Файл не создан.");
            }
        }
    }
}