using System;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MamatkulovFO.Sprint5.Task4.V27.Lib
{
    public class DataService : ISprint5Task4V27
    {
        public double CalculateFormulaFromDataFile(string tempPath)
        {
            // Чтение данных из файла
            string content = File.ReadAllText(tempPath).Trim();
            double x = double.Parse(content, CultureInfo.InvariantCulture); // Чтение числа в формате с точкой

            // Формула: y = (x^3 - 4x) / cos(x)
            double numerator = Math.Pow(x, 3) - 4 * x;
            double denominator = Math.Cos(x);

            // Проверка деления на ноль
            if (Math.Abs(denominator) < 1e-10)
                throw new DivideByZeroException("Cos(x) равен нулю!");

            double result = numerator / denominator;

            // Округление до 3 знаков после запятой
            return Math.Round(result, 3);
        }
    }
}

