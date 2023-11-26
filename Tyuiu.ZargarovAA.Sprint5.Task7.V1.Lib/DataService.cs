using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.ZargarovAA.Sprint5.Task7.V1.Lib
{
    public class DataService : ISprint5Task7V1
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = @"C:\Users\fairm\OneDrive\Рабочий стол\source\repos\Tyuiu.ZargarovAA.Sprint5\Tyuiu.ZargarovAA.Sprint5.Task7.V1\bin\Debug\OutPutDataFileTask7V1.txt";

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;


            char[] nums = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

            if (fileExists)
            {
                File.Delete(pathSaveFile);

            }

            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        char c = line[i];
                        if (Array.IndexOf(nums, c) < 0)
                        {
                            strLine = strLine + line[i];
                        }
                    }
                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                    strLine = "";
                }
            }
            return pathSaveFile;
        }
    }
}