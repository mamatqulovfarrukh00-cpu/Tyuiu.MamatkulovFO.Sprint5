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

            double max = numbers.Max();
            double min = numbers.Min();

            return Math.Round(max - min, 3); // Разница → должно быть 15.0
        }
    }
}
    
