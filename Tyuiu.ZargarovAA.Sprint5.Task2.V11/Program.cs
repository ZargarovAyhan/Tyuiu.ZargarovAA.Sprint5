using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using Tyuiu.ZargarovAA.Sprint5.Task2.V11.Lib;

namespace Tyuiu.ZargarovAA.Sprint5.Task2.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Заргаров А. А. | ИИПБ-23-2";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #5                                                                  *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл         *");
            Console.WriteLine("* Задание #2                                                                 *");
            Console.WriteLine("* Вариант #11                                                                *");
            Console.WriteLine("* Выполнил: Заргаров Айхан Ахатович | ИИПБ-23-2                              *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный значениями*");
            Console.WriteLine("* с клавиатуры. Заменить нечетные элементы массива на 0. Результат сохранить *");
            Console.WriteLine("* в файл OutPutFileTask2.csv и вывести на консоль.    4; 9; 3                *");
            Console.WriteLine("*                                                     5; 8; 8                *");
            Console.WriteLine("*                                                     5; 7; 5                *");

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            int[,] mtrx = new int[3, 3] {{4,9,3},
                                         {5,8,8},
                                         {5,7,5}};

            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.GetUpperBound(1) + 1;

            Console.WriteLine("Массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }

                Console.WriteLine();
            }

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");
            string res = ds.SaveToFileTextData(mtrx);

            Console.WriteLine($"Файл: {res}");
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
