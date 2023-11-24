using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AshirbakievAR.Sprint5.Task4.V25.Lib;
using System.IO;

namespace Tyuiu.AshirbakievAR.Sprint5.Task4.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask4V25.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
            Assert.AreEqual(67.1, ds.LoadFromDataFile(path));
        }
    }
}
