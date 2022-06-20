using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject
{
    internal class Multiplies3or5
    {
        static int NumbersMultiples3or5()
        {
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                bool isThree = false;
                bool isFive = false;
                isFive = Multiples5(i);
                isThree = Multiples3(i);
                if (isThree || isFive) sum += i;
            }
            return sum;
        }
        static bool Multiples3(int num)
        {
            if (num % 3 == 0) return true;
            else return false;
        }
        static bool Multiples5(int num)
        {
            if (num % 5 == 0) return true;
            else return false;
        }
    }
}
