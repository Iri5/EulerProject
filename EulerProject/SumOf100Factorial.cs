using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject
{
    internal class SumOf100Factorial
    {
        static int Sum(List<int> terms)
        {
            int sum = 0;
            foreach (int term in terms)
            {
                sum += term;
            }
            return sum;
        }
        static List<int> TheSumOfTheDigitsOfTheFactorial(List<int> divisors)
        {
            //создаем лист, где будет храниться первый множитель
            List<int> firstMultList = new List<int>();
            //добавляем первый множитель из листа с делителями (последний)
            firstMultList.Add(divisors[divisors.Count - 1]);
            //удаляем делитель из листа
            divisors.RemoveAt(divisors.Count - 1);
            //считываем второй множитель в переменную (последний)
            List<int> terms = new List<int>();
            //преобразовываем лист с первым множителем в массив

            //преобразовываем массив с первым множителем в строку
            for (int l = 0; l < divisors.Count;)
            {
                int[] firstMultArr = firstMultList.ToArray();
                int secondMult = divisors[divisors.Count - 1];
                //удаляем делитель из листа
                divisors.RemoveAt(divisors.Count - 1);
                string firstMultStr = String.Join("", firstMultArr);
                //подсчитываем кол-во цифр в первом множителе
                int countFirstMult = firstMultStr.Length;
                //преобразуем второй множитель в строку
                string secondMultStr = secondMult.ToString();
                //подсчитываем кол-во цифр во втором множителе
                int countSecondMult = secondMultStr.Length;
                //объявляем переменную для запоминания переноса разряда
                int toRemember = 0;
                int toRemList = 0;

                for (int k = 0; k <= countFirstMult - terms.Count; k++)
                {
                    terms.Insert(0, 0);
                }
                for (int i = countSecondMult - 1; i >= 0; i--)
                {
                    for (int j = countFirstMult - 1; j >= 0; j--)
                    {
                        int composition = ((firstMultStr[j] - '0') * (secondMultStr[i] - '0')) + toRemember;
                        if (composition > 9)
                        {
                            toRemember = composition / 10;
                        }
                        else
                        {
                            toRemember = 0;
                        }
                        int toAdd = composition % 10;
                        int inList;
                        if (i != countSecondMult - 1)
                        {
                            inList = terms[i + j] + toAdd;
                        }
                        else inList = toAdd;

                        if (inList > 9)
                        {
                            toRemList = inList / 10;
                        }
                        else
                        {
                            toRemList = 0;
                        }

                        terms[i + j] = inList % 10;



                    }
                    if ((toRemember != 0) || (toRemList != 0))
                    {
                        //terms[i  ] = toRemember + toRemList;
                        ////terms.Insert(0, toRemember + toRemList);
                        if (i != 0)
                        {
                            terms[i - 1] = toRemember + toRemList;
                        }
                        else
                        {
                            terms.Insert(0, toRemember + toRemList);
                        }
                    }
                }
                firstMultList.Clear();
                firstMultList.AddRange(terms);
            }

            int sum = Sum(terms);
            Console.WriteLine(sum);
            return terms;
        }
        static List<int> SimpleDivisorsOfNumber(int num)
        {
            List<int> list = new List<int>();
            int count = 2;
            if ((num != 0) && (num != 1))
            {
                while (num != 1)
                {
                    while (num % count == 0)
                    {
                        list.Add(count);
                        num /= count;
                    }
                    count++;
                }
            }
            return list;
        }
        static List<int> DivisorsOfList(int fact)
        {
            List<int> divisorsList = new List<int>();
            for (int i = 0; i <= fact; i++)
            {
                divisorsList.Add(i);
                // divisorsList.AddRange(SimpleDivisorsOfNumber(i));
            }
            divisorsList.Sort();
            return divisorsList;
        }
    }
}

