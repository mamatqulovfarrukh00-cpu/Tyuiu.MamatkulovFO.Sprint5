using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MamatkulovFO.Sprint5.Task6.V7.Lib
{
    public class DataService : ISprint5Task6V7
    {
        public int LoadFromDataFile(string path)
        {
            // Фақат биринчи қаторни ўқиймиз
            string line = File.ReadLines(path).First();

            int count = 0;
            foreach (char c in line)
            {
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
