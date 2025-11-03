using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MamatkulovFO.Sprint5.Task0.V13.Lib
{
    public class DataService : ISprint5Task0V13
    {
        public string SaveToFileTextData(int x)
        {
            // Вычисляем значение функции: F(x) = -1.4x³ + 2.3x² + 0.6x
            double result = -1.4 * Math.Pow(x, 3) + 2.3 * Math.Pow(x, 2) + 0.6 * x;

            // Форматируем результат до 3 знаков после запятой
            string formattedResult = $"{result:F3}";

            // Формируем полный путь к временному файлу OutPutFileTask0.txt
            string filePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            // Записываем результат в файл
            File.WriteAllText(filePath, formattedResult);

            // Выводим результат в консоль (для отладки/показа)
            Console.WriteLine($"F({x}) = {formattedResult}");

            // Возвращаем путь к созданному файлу
            return filePath;
        }
    }
}
 