using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MamatkulovFO.Sprint5.Task1.V8.Lib
{
    public class DataService : ISprint5Task1V8
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string fileName = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            StringBuilder content = new StringBuilder();

            content.AppendLine("x\t\tF(x)");
            content.AppendLine("----------------------");

            for (int x = startValue; x <= stopValue; x++)
            {
                double result;
                if (x == 1)
                {
                    result = 0; 
                }
                else
                {
                    result = 4 - 2 * x + (2 + Math.Cos(x)) / (2 * x - 2);
                    result = Math.Round(result, 2);
                }

                string line = $"{x}\t\t{result}";
                content.AppendLine(line);
            }

            File.WriteAllText(fileName, content.ToString());
            return fileName;
        }
    }
}
    

