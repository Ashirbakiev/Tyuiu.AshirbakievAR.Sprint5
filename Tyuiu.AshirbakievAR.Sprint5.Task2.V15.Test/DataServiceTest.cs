using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AshirbakievAR.Sprint5.Task2.V15.Lib;
using System.IO;

namespace Tyuiu.AshirbakievAR.Sprint5.Task2.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\admin\source\repos\Tyuiu.AshirbakievAR.Sprint5\Tyuiu.AshirbakievAR.Sprint5.Task2.V15\bin\Debug\OutPutFileTask2.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
