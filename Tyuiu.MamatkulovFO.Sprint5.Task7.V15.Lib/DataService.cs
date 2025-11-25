using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MamatkulovFO.Sprint5.Task7.V15.Lib
{
    public class DataService:ISprint5Task7V15
    {
        public string LoadDataAndSave(string path)
        {
            // Читаем весь текст из файла
            string text = File.ReadAllText(path);

            // Удаляем слова длиной 2 символа
            var words = text.Split(new char[] { ' ', '\n', '\r', '\t' }, System.StringSplitOptions.RemoveEmptyEntries);
            var filtered = words.Where(w => w.Length != 2);

            // Сохраняем результат в новый файл
            string outPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V15.txt");
            File.WriteAllText(outPath, string.Join(" ", filtered));

            return outPath;
        }
    }
}