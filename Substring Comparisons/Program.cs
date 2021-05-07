using System;

namespace Substring_Comparisons
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            short k = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(getSmallestAndLargest(s, k));
        }


        static string[] divideChain(string s, short k)
        {
            short i;
            string[] result = new string[s.Length - (k-1)];

            for(i=0; i<result.Length; i++)
            {
                result[i] = s.Substring(i, k);
            }

            return result;
        }

        static string getSmallestAndLargest(string s, short k)
        {
            string aux;
            short i = 1, j;
            bool isSort;
            string[] divide = divideChain(s, k);

            do
            {
                i++;
                isSort = true;

                for (j = 0; j < divide.Length - 1; j++)
                {
                    if (divide[j].CompareTo(divide[j + 1]) > 0)
                    {
                        isSort = false;

                        aux = divide[j];
                        divide[j] = divide[j + 1];
                        divide[j + 1] = aux;
                    }
                }


            }
            while (i < divide.Length || isSort == false);

            return divide[0] + "\n" + divide[divide.Length-1];
        }
    }
}