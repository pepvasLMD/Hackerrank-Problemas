using System;

namespace End_of_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            ulong contador = 1;

            do
            {
                entrada = Console.ReadLine();

                if(!string.IsNullOrEmpty(entrada))
                    Console.WriteLine(contador++ + " " + entrada);

            }
            while (!string.IsNullOrEmpty(entrada));
        }
    }
}
