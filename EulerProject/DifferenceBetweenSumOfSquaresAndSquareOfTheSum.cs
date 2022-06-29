using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject
{
    internal class DifferenceBetweenSumOfSquaresAndSquareOfTheSum
    {
        static int TheDifferenceBetweenTheSumOfSquaresAndTheSquareOfTheSum(int count)
        {
            int dif = TheSumOfSquares(count) - TheSquareOfTheSum(count);
            return dif;
        }
        static int TheSumOfSquares(int count)
        {
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += i * i;
            }
            return sum;
        }
        static int TheSquareOfTheSum(int count)
        {
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += i;
            }
            return Convert.ToInt32(Math.Pow(sum, 2));
        }
    }
}
