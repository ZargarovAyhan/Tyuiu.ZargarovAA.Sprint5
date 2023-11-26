using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.TarasovVD.Sprint5.Task5.V3.Lib

{
    public class DataService : ISprint5Task5V3
    {
        public double LoadFromDataFile(string path)
        {
            int sum = 0;


            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (int.TryParse(line.Trim(), out int number))
                    {
                        sum += number;
                    }
                }
            }
            return sum;
        }
    }
}