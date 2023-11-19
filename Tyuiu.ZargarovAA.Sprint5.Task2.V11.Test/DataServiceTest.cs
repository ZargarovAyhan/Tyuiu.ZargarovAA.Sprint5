using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.ZargarovAA.Sprint5.Task2.V11.Lib;

namespace Tyuiu.ZargarovAA.Sprint5.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {

            string path = @"C:\Users\fairm\OneDrive\Рабочий стол\source\repos\Tyuiu.ZargarovAA.Sprint5\Tyuiu.ZargarovAA.Sprint5.Task2.V11\bin\Debug\OutPutFileTask2.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}