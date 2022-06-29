using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject
{
    internal class PrimeNumber
    {
        static int PrimeNumber10001()
        {
            int count = 2;
            int n = 5;
            while (true)
            {
                if (IsPrime(n))
                {
                    count++;
                    if (count == 10001)
                    {
                        return n;
                    }
                }
                n++;
            }

        }
        static bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0 && i != number)
                    return false;
            }
            return true;
        }
    }
}
