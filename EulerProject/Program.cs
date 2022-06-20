using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int64 num = 600851475143;
            int big = TheLargestPrimeDivisor(num);
            Console.WriteLine(big);
        }
        static int TheLargestPrimeDivisor(Int64 num)
        {
            List<int> list = new List<int>();
            int count = 2;
            while (num != 1)
            {
                while (num % count == 0)
                {
                    list.Add(count);
                    num /= count;
                }
                count++;
            }
            int last = list[list.Count - 1];
            return last;
        }
    }
    
}
