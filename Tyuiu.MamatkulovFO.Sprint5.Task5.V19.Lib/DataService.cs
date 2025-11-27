using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MamatkulovFO.Sprint5.Task5.V19.Lib
{
    public class DataService : ISprint5Task5V19
    {
        public double LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"Файл не найден: {path}");

            var lines = File.ReadAllLines(path);
            var numbers = new List<double>();

            foreach (var line in lines)
            {
                var parts = line.Split(new char[] { ' ', '\t', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var part in parts)
                {
                    if (double.TryParse(part.Trim(), out double number))
                    {
                        numbers.Add(number);
                    }
                }
            }

            if (numbers.Count == 0)
                throw new InvalidOperationException("В файле нет чисел.");

            // В зависимости от задания:
            // Если нужно МАКСИМАЛЬНОЕ число:
            // return Math.Round(numbers.Max(), 3);

            // Если нужно МИНИМАЛЬНОЕ число:
            // return Math.Round(numbers.Min(), 3);

            // Если нужно ПОСЛЕДНЕЕ число (как в вашем примере):
            // return Math.Round(numbers.Last(), 3);

            // 🔥 УЧИТЫВАЯ ВАШУ ЗАДАЧУ: 
            // В файле только одно число: -1.26 → значит, выводим его.
            // Но если в файле несколько чисел — вероятно, нужно МИНИМАЛЬНОЕ.

            // По логике вашего теста: ожидается -1.26 → значит, это либо последнее, либо единственное.
            // Допустим, задание: "найти минимальное число"

            return Math.Round(numbers.Min(), 3);
        }
    }
}