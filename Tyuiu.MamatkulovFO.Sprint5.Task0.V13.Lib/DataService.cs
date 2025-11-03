using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MamatkulovFO.Sprint5.Task0.V13.Lib
{
    public class DataService : ISprint5Task0V13
    {
        public string SaveToFileTextData(int x)
        {
            // Вычисляем значение функции: F(x) = -1.4x³ + 2.3x² + 0.6x
            double result = -1.4 * Math.Pow(x, 3) + 2.3 * Math.Pow(x, 2) + 0.6 * x;

            // Форматируем число: округляем до 3 знаков, но убираем незначащие нули
            // Используем "G" или "F3", затем TrimEnd('0') и TrimEnd(',')
            string formattedResult = result.ToString("F3").TrimEnd('0').TrimEnd(',');

            // Если после удаления нулей осталась точка — заменяем на запятую (для русской локали)
            // Но в задании явно требуется запятая, поэтому делаем замену
            formattedResult = formattedResult.Replace('.', ',');

            // Если после запятой ничего нет — убираем саму запятую
            if (formattedResult.EndsWith(","))
                formattedResult = formattedResult.Substring(0, formattedResult.Length - 1);

            // Формируем путь к файлу
            string filePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            // Записываем результат в файл
            File.WriteAllText(filePath, formattedResult);

            // Выводим результат в консоль
            Console.WriteLine($"F({x}) = {formattedResult}");

            return filePath;
        }
    }
}
    

 