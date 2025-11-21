using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MamatkulovFO.Sprint5.Task1.V8.Lib
{
    /// <summary>
    /// Класс для вычисления функции F(x) и сохранения результатов в текстовый файл.
    /// </summary>
    public class DataService:ISprint5Task1V8
    {
        /// <summary>
        /// Вычисляет значения функции F(x) = 4 - 2x + (2 + cos(x)) / (2x - 2)
        /// на отрезке [startValue; stopValue] с шагом 1 и сохраняет результат в файл.
        /// При x = 1 (деление на ноль) результат = 0.
        /// </summary>
        /// <param name="startValue">Начало диапазона (включительно)</param>
        /// <param name="stopValue">Конец диапазона (включительно)</param>
        /// <returns>Путь к созданному файлу</returns>
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            // Полный путь к временной папке + имя файла
            string fileName = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            StringBuilder content = new StringBuilder();

            // Заголовок таблицы
            content.AppendLine("x\t\tF(x)");
            content.AppendLine("----------------------");

            // Цикл по всем целым x от startValue до stopValue
            for (int x = startValue; x <= stopValue; x++)
            {
                double result;
                if (x == 1)
                {
                    // Защита от деления на ноль: при x = 1 знаменатель = 0
                    result = 0;
                }
                else
                {
                    // Вычисление функции
                    result = 4 - 2 * x + (2 + Math.Cos(x)) / (2 * x - 2);
                    // Округление до 2 знаков после запятой
                    result = Math.Round(result, 2);
                }

                // Форматирование строки и добавление в буфер
                string line = $"{x}\t\t{result}";
                content.AppendLine(line);
            }

            // Запись всего содержимого в файл
            File.WriteAllText(fileName, content.ToString());
            return fileName;
        }
    }
}

