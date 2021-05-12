using System;

namespace Output_Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] entradas = new string[3][];

            entradas[0] = Console.ReadLine().Split(" ");
            entradas[1] = Console.ReadLine().Split(" ");
            entradas[2] = Console.ReadLine().Split(" ");

            for (int i =0; i<entradas.Length; i++)
            {
                for(int j=entradas[i][0].Length; j<15; j++)
                {
                    entradas[i][0] += " ";
                }

                for(int j=entradas[i][1].Length; j<3; j++)
                {
                    entradas[i][1] = "0" + entradas[i][1];
                }

                Console.WriteLine(entradas[i][0] + entradas[i][1]);
            }

        }
    }
}
