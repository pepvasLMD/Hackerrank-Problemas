﻿using System;
using System.Numerics;

namespace BigIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger a = BigInteger.Parse(Console.ReadLine());
            BigInteger b = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine(a + b);
            Console.WriteLine(a * b);
        }
    }
}