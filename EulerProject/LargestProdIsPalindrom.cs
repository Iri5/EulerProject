using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject
{
    internal class LargestProdIsPalindrom
    {
        static int TheLargestProductIsAPalindrome()
        {
            int res = 0;
            for (int i = 999; i > 99; i--)
            {
                for (int j = 999; j > 99; j--)
                {
                    res = i * j;
                    List<int> need = Digits(res);
                    if (IsPalindrom(need))
                    {
                        return res;
                    }
                }
            }
            return res;
        }
        static bool IsPalindrom(List<int> num)
        {
            int[] arr = num.ToArray();
            int[] second = new int[arr.Length / 2];
            int[] first = new int[arr.Length / 2];
            Array.Copy(arr, 0, first, 0, arr.Length / 2);
            Array.Copy(arr, arr.Length / 2, second, 0, arr.Length / 2);
            Array.Reverse(second);
            bool isPal = first.SequenceEqual(second);
            return isPal;
        }
        static List<int> Digits(int num)
        {
            List<int> list = new List<int>();
            do
            {
                list.Add(num % 10);
                num /= 10;
            }
            while (num > 0);
            list.Reverse();
            return list;
        }
    }
}
