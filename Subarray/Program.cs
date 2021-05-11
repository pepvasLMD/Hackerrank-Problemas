using System;

namespace Subarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroEntradas = Convert.ToInt32(Console.ReadLine());

            string[] entrada = Console.ReadLine().Split(" ");
            int[] array = new int[numeroEntradas];
            bool tieneNegativo;
            int suma;
            int contadorSubarray = 0;

            for(int i=0; i<array.Length; i++)
            {
                array[i] = Convert.ToInt32(entrada[i]);
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    tieneNegativo = false;
                    suma = 0;

                    for (int k = i; k <=j; k++)
                    {
                        if(array[k] < 0)
                        {
                            tieneNegativo = true;
                        }

                        suma += array[k];
                    }

                    if (tieneNegativo && suma < 0)
                    {
                        contadorSubarray++;
                    }
                }
            }

            Console.WriteLine(contadorSubarray);
        }
    }
}
