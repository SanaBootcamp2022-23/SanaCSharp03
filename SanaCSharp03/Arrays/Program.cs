using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            double[] numbers = new double[n];
            for(int i = 0; i < n; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
            }

            double sum = 0;

            for(int i =0;i < n; i++)
            {
                if (numbers[i] < 0) sum += numbers[i];
            }

            Console.WriteLine($"Sum of negative numbers: {sum}");

            int max = 0;

            for(int i = 1;i < n; i++)
            {
                if (numbers[i] > numbers[max]) max = i;
            }

            Console.WriteLine($"Max element in array: {numbers[max]}");
            Console.WriteLine($"Index of max element in array: {max}");

            max = 0;

            for(int i = 1; i < n; i++)
            {
                if (Math.Abs(numbers[i]) > Math.Abs(numbers[max])) max = i;
            }

            Console.WriteLine($"Max element by module int array: {max}");

            int index_sum = 0;
            for(int i = 0;i  < n; i++)
            {
                if (numbers[i] > 0) index_sum += i;
            }

            Console.WriteLine($"Sum indexes of numbers that greated than 0: {index_sum}");

            int counter = 0;
            for(int i = 0;i  < n; i++)
            {
                if (Math.Floor(numbers[i]) == numbers[i]) counter++; 
            }

            Console.WriteLine($"Counf of integer numbers: {counter}");

        }
    }
}
