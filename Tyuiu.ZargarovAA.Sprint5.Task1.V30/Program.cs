using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ZargarovAA.Sprint5.Task1.V30.Lib;


namespace Tyuiu.ZargarovAA.Sprint5.Task1.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Заргаров А.А. | ИИПБ-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Заргаров Айхан Ахатович | ИИПБ-23-2                           *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция f(x) = cos(x) + sin(x)/2-2x - 4x на диапазоне [-5;5] с     *");
            Console.WriteLine("* шагом 1. Произвести проверку деления на ноль При делении на 0 вернуть 0 *");
            Console.WriteLine("* Результат сохранить в текстовый файл OutPutFileTask1.txt и выводить на  *");
            Console.WriteLine("* консоль в таблицу. Округлить до трёх знаков после запятой.              *");
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Файл: " + ds.SaveToFileTextData(startValue, stopValue));
            Console.WriteLine("Создан! ");
            Console.ReadKey();
        }
    }
}

