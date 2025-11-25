using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MamatkulovFO.Sprint5.Task6.V7.Lib
{
    public class DataService : ISprint5Task6V7
    {
        public int LoadFromDataFile(string path)
        {
            string line = File.ReadAllText(path); // Читаем всё содержимое файла как одну строку
            int count = 0;

            // Проходим по каждому символу строки
            foreach (char c in line)
            {
                // Проверяем, является ли символ латинской буквой (a-z или A-Z)
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                {
                    count++;
                }
            }

            return count; // Возвращаем количество латинских букв
        }
    }
}
