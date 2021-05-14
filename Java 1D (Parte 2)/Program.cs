using System;

namespace Java_1D__Parte_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int q, n, leap;


            q = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<q; i++)
            {
                string[] input = Console.ReadLine().Split(" ");

                n = Convert.ToInt32(input[0]);
                leap = Convert.ToInt32(input[1]);

                int[] array = new int[n];

                string[] game = Console.ReadLine().Split(" ");

                for(int j=0; j<n; j++)
                {
                    array[j] = Convert.ToInt32(game[j]);
                }

                if(checkWin(0, ref leap, ref array))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }

            }




        }

        public static bool checkWin(int i, ref int leap, ref int[] array)
        {
            if(i < array.Length)
            {
                if (array[i] == 0)
                {
                    if (i == (array.Length - 1))
                    {
                        return true;
                    }
                    else
                    {

                        return checkWin((i + 1), ref leap, ref array) || checkWin((i + leap), ref leap, ref array);
                    }
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
