﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.AshirbakievAR.Sprint5.Task7.V20.Lib;

namespace Tyuiu.AshirbakievAR.Sprint5.Task7.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\admin\source\repos\Tyuiu.AshirbakievAR.Sprint5\Tyuiu.AshirbakievAR.Sprint5.Task7.V20\bin\Debug\OutPutDataFileTask7V20.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
