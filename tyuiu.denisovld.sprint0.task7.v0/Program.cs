using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using tyuiu.denisovld.sprint0.task7.v0.lib;
namespace tyuiu.denisovld.sprint0.task7.v0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Title = "Спринт 0 | Выполнено by Денисов Л. Д. | АСОиУб-26-1";
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("* Спринт #0                                                                                     *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                                                   *");
            Console.WriteLine("* Задание 7                                                                                     *");
            Console.WriteLine("* Вариант 0                                                                                     *");
            Console.WriteLine("* Выполнено by Денисов Л. Д. | АСОиУб-26-1                                                      *");
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                      *");
            Console.WriteLine("* Написать консольную программу на С#, которая суммирует значения двух                          *");
            Console.WriteLine("* одинаковых массивов по длине.                                                                 *");
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                                               *");
            Console.WriteLine("*************************************************************************************************");
            int[] arrayNums1 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Значение элементов массива #1");
            for (int i = 0; i < arrayNums1.Length; i++)
            {
                Console.Write(arrayNums1[i] + ",");
            }

            Console.WriteLine();

            int[] arrayNums2 = new int[] { 1, 2, 3, 4, 5, };
            Console.WriteLine("Значение элементов массива #2");
            for (int i = 0; i < arrayNums2.Length; i++)
            {
                Console.Write(arrayNums2[i] + ",");
            }

            Console.WriteLine();
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                                     *");
            Console.WriteLine("*************************************************************************************************");

            if (arrayNums1.Length == arrayNums2.Length)
            {
                int[] resultArrays = DataService.AdditionArrays(arrayNums1, arrayNums2);
                Console.WriteLine("Сумма элементов массивов равна: ");
                for (int i = 0; i < resultArrays.Length; i++)
                {
                    Console.Write(resultArrays[i] + ", ");
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Исходные массивы имеют разное количество элементов");
            }
            Console.ReadKey();
        }
    }
}
