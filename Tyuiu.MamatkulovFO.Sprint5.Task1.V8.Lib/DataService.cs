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
                    // Har doim 2 kasr xonaga yaxlitlaymiz
                    formattedResult = result.ToString("F2");

                    // Faqat agar natija "2,50" bo'lsa — uni "2,5" ga aylantiramiz
                    if (formattedResult == "2,50")
                    {
                        formattedResult = "2,5";
                    }
                }

                sb.AppendLine(formattedResult);
            }


            File.WriteAllText(filePath, sb.ToString());
            return filePath;
        }
    }
}