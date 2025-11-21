using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MamatkulovFO.Sprint5.Task2.V14.Lib
{
    public class DataService : ISprint5Task2V14
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string fileName = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");
            StringBuilder content = new StringBuilder();

            for (int i = 0; i < 3; i++)
            {
                string line = "";
                for (int j = 0; j < 3; j++)
                {
                    line += matrix[i, j] > 0 ? "1" : "0";
                    if (j < 2) line += ";";
                }
                content.AppendLine(line);
            }

            File.WriteAllText(fileName, content.ToString());
            return fileName;
        }
    }
}
