using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZargarovAA.Sprint5.Task0.V16.Lib;
using System.IO;

namespace Tyuiu.ZargarovAA.Sprint5.Task0.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\fairm\OneDrive\Рабочий стол\source\repos\Tyuiu.ZargarovAA.Sprint5\Tyuiu.ZargarovAA.Sprint5.Task0.V16\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
