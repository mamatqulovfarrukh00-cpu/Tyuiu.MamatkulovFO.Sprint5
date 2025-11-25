// <summary>
// Класс для выполнения задания Sprint5.Task6.V7
// Считает количество строчных (маленьких) латинских букв в файле.
// </summary>
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MamatkulovFO.Sprint5.Task6.V7.Lib
{
    public class DataService : ISprint5Task6V7
    {
        /// <summary>
        /// Считывает файл и возвращает количество строчных латинских букв (a-z).
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <returns>Количество строчных латинских букв</returns>
        public int LoadFromDataFile(string path)
        {
            string content = File.ReadAllText(path); // Читаем ВЕСЬ файл как одну строку
            return content.Count(c => c >= 'a' && c <= 'z'); // Только маленькие a-z
        }
    }
}