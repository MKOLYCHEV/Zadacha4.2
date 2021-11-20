using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = 0, n = 0, num;
            do
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num < 0)
                    n++;
                else if (num > 0)
                    p++;
            } while (num!=0);
            if (p>n)
            {
                Console.WriteLine("Количество положительных чисел больше, чем отрицательных.");
            }
            else if(n>p)
            {
                Console.WriteLine("Количество отрицательных чисел больше, чем положительных.");
            }
            else if (n==p&&p==0)
            {
                Console.WriteLine("Ошибка! Первое введенное число - ноль.");
            }
            else Console.WriteLine("Количество отрицательных чисел ровно количеству положительных.");
            Console.ReadKey();
        }
    }
}
