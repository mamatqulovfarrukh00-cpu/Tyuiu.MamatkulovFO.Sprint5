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
                if (2 * x - 2 == 0)
                {
                    result = 0;
                }
                else
                {
                    result = 4 - 2 * x + (2 + Math.Cos(x)) / (2 * x - 2);
                }

                string formattedResult;
                if (Math.Abs(result) < 1e-10) 
                {
                    formattedResult = "0";
                }
                else
                {
                  
                    formattedResult = result.ToString("F1");
                   
                    if (formattedResult.EndsWith(",0"))
                    {
                        formattedResult = formattedResult.Substring(0, formattedResult.Length - 2);
                    }
                }

                sb.AppendLine(formattedResult);
            }

            File.WriteAllText(filePath, sb.ToString());
            return filePath;
        }
    }
}
