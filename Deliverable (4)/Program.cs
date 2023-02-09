/*
Author: Yuhang Bai
Date: 2/9/2023
Descrription: This C# console application provides practical examples of arrays
*/

using System;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibonacci = new int[25];
            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for (int i = 2; i < fibonacci.Length; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }

            for (int i = 0; i < fibonacci.Length; i++)
            {
                Console.WriteLine("Fibonacci number ({0}) = {1}", i, fibonacci[i]);
            }
            Console.ReadLine();
        }
    }
}