using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MamatkulovFO.Sprint5.Task6.V7.Lib
{
    public class DataService : ISprint5Task6V7
    {
        public int LoadFromDataFile(string path)
        {
            string line = File.ReadLines(path).First(); // ФАҚАТ БИРИНЧИ ҚАТОР
            return line.Count(c => (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'));
        }
    }
}