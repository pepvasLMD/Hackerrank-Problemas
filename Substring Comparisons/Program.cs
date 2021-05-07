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
            string smallString, largestString;
            short i;
            string[] divide = divideChain(s, k);

            smallString = divide[0];
            largestString = divide[0];

            for (i = 0; i < divide.Length; i++)
            {
                if (smallString.CompareTo(divide[i]) > 0)
                {
                    smallString = divide[i];
                }

                if (largestString.CompareTo(divide[i]) < 0)
                {
                    largestString = divide[i];
                }
            }

            return smallString + "\n" + largestString;
        }
    }
}