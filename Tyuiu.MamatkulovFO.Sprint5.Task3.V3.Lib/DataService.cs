using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MamatkulovFO.Sprint5.Task3.V3.Lib
{
    public class DataService : ISprint5Task3V3
    {
        public string SaveToFileTextData(int x)
        {
            double result = x * Math.Sqrt(x + 3);
            result = Math.Round(result, 3);

            string filePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {
                writer.Write(result);
            }
            return filePath;
        }
    }
}
