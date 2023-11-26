using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.ZargarovAA.Sprint5.Task4.V4.Lib;

namespace Tyuiu.ZargarovAA.Sprint5.Task4.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedLoadFromDataFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V4.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(fileExists, true);
        }
    }
}