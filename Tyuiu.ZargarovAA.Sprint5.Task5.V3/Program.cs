using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TarasovVD.Sprint5.Task5.V3.Lib;

namespace Tyuiu.TarasovVD.Sprint5.Task5.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Заргаров А. А. | ИИПБ-23-2 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Заргаров Айхан Ахатович | ИИПБ-23-2                           *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:DataSprint5InPutDataFileTask5V3.txt (файл взять из архива    *");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную С:DataSprint5 и        *");
            Console.WriteLine("* скопировать в неё файл) в котором есть набор значений. Найти сумму      *");

            Console.WriteLine("* всех целых чисел в файле. Полученный результат вывести на консоль. У    *");
            Console.WriteLine("* вещественных значений округлить до трёх знаков после запятой.           *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask5V3.txt";
            Console.WriteLine("Данные находятся в файле: " + path);
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Сумма элементов файла = " + res);



            Console.ReadKey();
        }
    }
}