using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject
{
    internal class EvenFibonacciNumbers
    {
        static void EvenFibonacciNum(ref int sum)
        {
            int num = 0;
            int i = 0;
            while (num < 4000000)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("i");
                    num = Fibonachi(i);
                    if (num < 4000000)
                    {
                        Console.WriteLine(num);
                        sum += num;
                    }
                }
                i++;
            }
        }

        static int Fibonachi(int n)
        {
            if (n == 0 || n == 1) return n;
            return Fibonachi(n - 1) + Fibonachi(n - 2);
        }
    }

}
