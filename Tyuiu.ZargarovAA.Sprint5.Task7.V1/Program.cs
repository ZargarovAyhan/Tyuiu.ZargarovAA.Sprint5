using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ZargarovAA.Sprint5.Task7.V1.Lib;
using System.IO;

namespace Tyuiu.ZargarovAA.Sprint5.Task7.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Заргаров А.А | ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант 1                                                               *");
            Console.WriteLine("* Выполниа: Заргаров Айхан Ахатович | ИИПб-23-2                           *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл в котором есть набор символьных данных. Удалить все цифры из   *");
            Console.WriteLine("* файла. Полученный результат сохранить в файл OutPutDataFileTask7V1.txt. *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask7V1.txt";
            Console.WriteLine("Исходные данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string pathSaveFile = @"C:\Users\fairm\OneDrive\Рабочий стол\source\repos\Tyuiu.ZargarovAA.Sprint5\Tyuiu.ZargarovAA.Sprint5.Task7.V1\bin\Debug\OutPutDataFileTask7V1.txt";
            Console.WriteLine("Конечные данные находятся в файле: " + pathSaveFile);

            pathSaveFile = ds.LoadDataAndSave(path);


            Console.ReadKey();
        }
    }
}

