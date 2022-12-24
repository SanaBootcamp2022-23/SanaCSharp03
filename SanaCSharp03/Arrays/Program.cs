﻿using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double[] numbers = new double[N];
            for (int i = 0; i < N; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Your array:");
            for (int i = 0; i < N; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();

            double negSum = 0;
            int posIndexSum = 0;
            for (int i = 0; i < N; i++)
            {
                if (numbers[i] <= 0)
                {
                    negSum+=numbers[i];
                }
                else
                {
                    posIndexSum+=i;
                }
            }

            double maxElement = numbers[0];
            int maxIndex = 0;
            for (int i = 0; i < N; i++)
            {
                if (numbers[i]>maxElement)
                {
                    maxElement = numbers[i];
                    maxIndex = i;
                }
            }

            double maxAbs = numbers[0];
            for (int i = 0; i < N; i++)
            {
                if (Math.Abs(numbers[i]) > Math.Abs(maxAbs))
                {
                    maxAbs = numbers[i];
                }
            }

            int integerCount = 0;
            for (int i = 0; i < N; i++)
            {
                if (numbers[i] % 1 == 0)
                {
                    integerCount++;
                }
            }


            Console.WriteLine($"Sum of negatives: {negSum}");
            Console.WriteLine($"Max element: {maxElement}");
            Console.WriteLine($"Max element index: {maxIndex}");
            Console.WriteLine($"Max abs number: {maxAbs}");
            Console.WriteLine($"Sum of positive`s indexes: {posIndexSum}");
            Console.WriteLine($"Number of integers: {integerCount}");



        }
    }
}