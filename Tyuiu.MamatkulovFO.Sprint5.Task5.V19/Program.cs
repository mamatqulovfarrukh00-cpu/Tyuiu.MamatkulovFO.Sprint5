using System;
using Tyuiu.MamatkulovFO.Sprint5.Task5.V19.Lib;

namespace Tyuiu.MamatkulovFO.Sprint5.Task5.V19
{
    class Program
    {
        static void Main()
        {
            // Faylni temp papkada yaratamiz
            string tempFile = Path.GetTempFileName();
            File.WriteAllText(tempFile, "16, 15.24, 9, 8, 11, 19, -3.43, -6, 9.4, 20, 11.67, 1.72");

            var service = new DataService();
            double result = service.LoadFromDataFile(tempFile);

            Console.WriteLine(result); // Chiqish: 1.000
            Console.ReadKey();

            // Faylni o'chirish
            File.Delete(tempFile);
        }
    }
}