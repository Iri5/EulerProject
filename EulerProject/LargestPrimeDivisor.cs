using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject
{
    internal class LargestPrimeDivisor
    {
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
