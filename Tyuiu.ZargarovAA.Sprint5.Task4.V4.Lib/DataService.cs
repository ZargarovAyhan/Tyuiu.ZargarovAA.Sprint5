using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZargarovAA.Sprint5.Task4.V4.Lib
{
    public class DataService : ISprint5Task4V4
    {
        public double LoadFromDataFile(string path)
        {

            string str = File.ReadAllText(path);
            str = str.Replace('.', ',');

            double res = (0.25 * Convert.ToDouble(str)) / Math.Cos(Convert.ToDouble(str));

            res = Math.Round(res, 3);
            return res;
        }
    }
}