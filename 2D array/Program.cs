using System;

namespace _2D_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array = new int[6][];
            int suma, maximo = 0;

            for(int i=0; i<array.Length; i++)
            {
                string[] entrada = Console.ReadLine().Split(" ");
                array[i] = new int[6];

                for(int j=0; j<entrada.Length; j++)
                {
                    array[i][j] = Convert.ToInt32(entrada[j]);
                }
            }


            for(int i=0; i<4; i++)
            {
                for(int j=0; j<4; j++)
                {
                    suma = 0;
                    suma += array[i][j] + array[i][j + 1] + array[i][j + 2];
                    suma += array[i + 1][j + 1];
                    suma += array[i+2][j] + array[i+2][j + 1] + array[i+2][j + 2];

                    if(suma > maximo)
                    {
                        maximo = suma;
                    }
                }
            }

            Console.WriteLine(maximo);
        }
    }
}
