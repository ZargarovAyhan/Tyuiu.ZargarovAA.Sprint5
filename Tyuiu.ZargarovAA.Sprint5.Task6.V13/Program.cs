using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ZargarovAA.Sprint5.Task6.V13.Lib;

namespace Tyuiu.ZargarovAA.Sprint5.Task6.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Заргаров А. А. | ИИПБ-23-2";
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                            *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                                     *");

            Console.WriteLine("* Таск #6                                                                              *");
            Console.WriteLine("* Вариaнт #13                                                                          *");
            Console.WriteLine("* Выполнил: Заргаров Айхан Ахатович  | ИИПБ-23-2                                       *");
            Console.WriteLine("****************************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask6V13.txt";

            Console.WriteLine("Данные находятся в файле: " + path);


            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТAТ:                                                                            *");
            Console.WriteLine("*****************************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
