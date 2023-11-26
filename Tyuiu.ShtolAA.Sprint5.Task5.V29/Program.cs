using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ShtolAA.Sprint5.Task5.V29.Lib;

namespace Tyuiu.ShtolAA.Sprint5.Task5.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Штоль А.А. | ИИПб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнила: Штоль Александра Алексеевна | ИИПб-23-3                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая берёт набор значение из                     *");
            Console.WriteLine("* InPutDataFileTask5V29.txt и находит минимальное целое число в файле,    *");
            Console.WriteLine("* которое является двузначным числом.                                     *");
            Console.WriteLine("* У вещественных значений округлить до трёх знаков после запятой.         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask5V29.txt";
            Console.WriteLine("Данные находятся в файле: " + path);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Минимальное целое двузначное число в файле = " + res);
            Console.ReadKey();
        }
    }
}
