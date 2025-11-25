using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MamatkulovFO.Sprint5.Task6.V7.Lib
{
    public class DataService : ISprint5Task6V7
    {
        public int LoadFromDataFile(string path)
        {
            // Фақат биринчи қаторни ўқиймиз
            string line = File.ReadLines(path).First();

            // Фақат a-z ва A-Z ҳарфларини санаймиз
            return line.Count(c => (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'));
        }
    }
}