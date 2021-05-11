using System;

namespace _1D_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[Convert.ToInt32(Console.ReadLine())];

            for(int i=0; i< myArray.Length; i++)
            {
                myArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i=0; i<myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}
