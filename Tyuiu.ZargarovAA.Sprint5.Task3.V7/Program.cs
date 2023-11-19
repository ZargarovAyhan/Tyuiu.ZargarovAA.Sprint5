using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using Tyuiu.ZargarovAA.Sprint5.Task3.V7.Lib;

namespace Tyuiu.ZargarovAA.Sprint5.Task3.V7
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Заргаров А. А. | ИИПБ-23-2";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                *");
            Console.WriteLine("* Тема: Обработка файлов                                                   *");
            Console.WriteLine("* Задание #3                                                               *");
            Console.WriteLine("* Вариант #7                                                               *");
            Console.WriteLine("* Выполнил: Заргаров Айхан Ахатович | ИИПБ-23-2                            *");

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дано выражение f(x) = 1.6*x^3-2.1*x^2+7*x, вычислить его значение при    *");
            Console.WriteLine("* x = 2, результат сохранить в бинарный файл OutPutFileTask3.bin и вывести *");
            Console.WriteLine("* на консоль. Округлить до трёх знаков после запятой.                      *");

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            int x = 2;
            Console.WriteLine("x = " + x);


            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");

            Console.WriteLine("Результат: ");
            Console.WriteLine(1.6 * (Math.Pow(x, 3)) - 2.1 * (Math.Pow(x, 2)) + 7 * x);

            Console.ReadKey();


        }
    }
}
