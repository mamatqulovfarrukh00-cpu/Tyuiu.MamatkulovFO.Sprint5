using Tyuiu.MamatkulovFO.Sprint5.Task1.V8.Lib;
namespace Tyuiu.MamatkulovFO.Sprint5.Task1.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("F(x) = 4 - 2x + (2 + cos(x)) / (2x - 2) funksiyasini [-5; 5] oraliqda hisoblaymiz.\n");

            var service = new DataService();
            string fileName = service.SaveToFileTextData(-5, 5);

            // Natijani konsolga chiqaramiz
            string[] lines = System.IO.File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine($"\n📁 Natijalar saqlangan fayl: {fileName}");

            // Testni ishga tushiramiz
            Console.WriteLine("\n🧪 Testni boshlaymiz...");
            DataServiceTest.RunTest();

            Console.ReadKey();
        }
    }
}
