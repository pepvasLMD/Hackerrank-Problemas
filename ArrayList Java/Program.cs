using System;
using System.Collections.Generic;

namespace ArrayList_Java
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, q;
            List<List<int>> arreglo = new List<List<int>>();

            n = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<n; i++)
            {
                List<int> numeros = new List<int>();

                string[] entrada = Console.ReadLine().Split(" ");

                for(int j=1; j<entrada.Length; j++)
                {
                    numeros.Add(Convert.ToInt32(entrada[j]));
                }

                arreglo.Add(numeros);
            }


            q = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<q; i++)
            {
                string[] entrada = Console.ReadLine().Split(" ");
                int start = Convert.ToInt32(entrada[0]);
                int end = Convert.ToInt32(entrada[1]);

                if (start > 0 && start <=arreglo.Count)
                {
                    if (end > 0 && end <= arreglo[start-1].Count)
                    {
                        Console.WriteLine(arreglo[start-1][end-1]);
                    }
                    else
                    {
                        Console.WriteLine("ERROR!");
                    }
                }
                else
                {
                    Console.WriteLine("ERROR!");
                }
                
            }

            
        }
    }
}
