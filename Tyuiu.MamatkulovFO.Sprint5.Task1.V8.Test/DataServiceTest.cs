using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MamatkulovFO.Sprint5.Task1.V8.Lib;

namespace Tyuiu.MamatkulovFO.Sprint5.Task1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var service = new DataService();
            string path = service.SaveToFileTextData(-5, 5);

            Assert.IsTrue(File.Exists(path));
        }
    }
}