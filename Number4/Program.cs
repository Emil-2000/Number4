using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number4
{
    class Program
    {
        /// <summary>
        /// Объявление функции f, (сумма заданного ряда)
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        static double f(int i)
        {
            double res;
            res = 1 / Math.Pow(i, 8);
            return res;
        }
        /// <summary>
        /// Задача эпсилон
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double e;
            Console.WriteLine("Введите заданную точность e ");
            string inp;
            do
            {
                try
                {
                    inp= Console.ReadLine();
                    e = Convert.ToDouble(inp);
                    if (e <= 0)
                    {
                        Console.WriteLine("Ошибка ввода, введите число с плавающей точкой и разделителем , например 0,002. \n Число должно быть положительным и больше нуля.");
                        Console.WriteLine("Повторите ввод");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                    
                }
                catch
                {
                    Console.WriteLine("Ошибка ввода, введите число с плавающей точкой и разделителем , например 0,002. \n Число должно быть положительным и больше нуля.");
                    Console.WriteLine("Повторите ввод");

                }
                
            } while (true);
            

            //previous-значение предыдущего, current - текущего, sum -значение всего ряда
            double previuos = 0;
            double current = 0;
            double sum = 0;
            int i = 1;

            //вычисление первого ряда в цикле            
            do
            {
                previuos = current;
                current = f(i);
                sum += current;
                i++;
            } while (Math.Abs(current - previuos) > e);

            Console.WriteLine("Сумма ряда, с заданным эпсилоном (" + e + ") = " + sum.ToString());
            Console.WriteLine("Выполнено " + i + " итераций");
            Console.ReadKey();
        }

    }
}
