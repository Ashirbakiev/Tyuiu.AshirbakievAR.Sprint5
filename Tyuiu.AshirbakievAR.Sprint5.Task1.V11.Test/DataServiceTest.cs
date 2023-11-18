using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AshirbakievAR.Sprint5.Task1.V11.Lib;
using System.IO;

namespace Tyuiu.AshirbakievAR.Sprint5.Task1.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\admin\source\repos\Tyuiu.AshirbakievAR.Sprint5\Tyuiu.AshirbakievAR.Sprint5.Task1.V11\bin\Debug\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
