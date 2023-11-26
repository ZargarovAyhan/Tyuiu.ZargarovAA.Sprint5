using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using Tyuiu.ZargarovAA.Sprint5.Task4.V4.Lib;

namespace Tyuiu.ZargarovAA.Sprint5.Task4.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Заргаров А. А. | ИИПб-23-2 ";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнила: Заргаров Айхан Ахатович  | ИИПб-23-2                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:DataSprint5InPutDataFileTask4V0.txt (файл взять из архива    *");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную С:DataSprint5 и        *");
            Console.WriteLine("* скопировать в неё файл) в котором есть вещественное значение. Прочитать *");
            Console.WriteLine("* значение из файла и подставить вместо Х в формуле. Вычислить значение   *");

            Console.WriteLine("* по формуле (Полученное значение округлить до трёх знаков после запятой) *");
            Console.WriteLine("* и вернуть полученный результат на консоль.                              *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

            Console.WriteLine("***************************************************************************");

            string path = $@"C:\DataSprint5\InPutDataFileTask4V4.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");

            Console.WriteLine("***************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();

        }
    }
}