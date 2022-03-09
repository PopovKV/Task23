using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число, факториал которого надо найти:");
            int n=Convert.ToInt32(Console.ReadLine());

            int r = FactorialAsync(n).Result;

            Console.WriteLine("Факториал числа = {0}", r);
            Console.ReadKey();
        }

        static int Factorial(int a)
        {
            int r = 1;
            if (a!=0)
            {
                for (int i = 1; i <= a; i++)
                {
                    r *= i;
                }
            }

            return (r);
        }

        static async Task<int> FactorialAsync(int a)
        {
            int result = await Task.Run(() => Factorial(a));
            return result;
        }
    }
}
