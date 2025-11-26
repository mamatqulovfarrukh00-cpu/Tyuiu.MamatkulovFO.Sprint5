using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MamatkulovFO.Sprint5.Task1.V8.Lib
{
    public class DataService:ISprint5Task1V8
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string filePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            StringBuilder sb = new StringBuilder();

            for (int x = startValue; x <= stopValue; x++)
            {
                double result = 0;
                if (2 * x - 2 == 0) // Nolga bo'lishni tekshirish
                {
                    result = 0;
                }
                else
                {
                    result = 4 - 2 * x + (2 + Math.Cos(x)) / (2 * x - 2);
                }

                string line = $"{x};{result:F2}";
                sb.AppendLine(line);

                // Konsolga ham chiqarish
                Console.WriteLine(line);
            }

            File.WriteAllText(filePath, sb.ToString());
            return filePath;
        }
    }
}