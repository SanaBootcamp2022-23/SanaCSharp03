using Helpers;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The program \"Arrays\"\n");

            ConsoleReader.MakeCustomSeparator();

            Console.WriteLine("Please enter length of array.");
            var lengthOfArr = ConsoleReader.ReadInt("length", 1);
            var arr = new double[lengthOfArr];

            Console.WriteLine("\nPlease enter items of array.");
            FillArray(arr);

            Console.WriteLine("\nYour array:");
            Console.WriteLine(ArrayToString(arr));

            Console.WriteLine("\nRESULTS:");
            Console.WriteLine($"1) Sum of negative elements of the array: {SumOfNegativeElementsInArray(arr)}");
            Console.WriteLine($"2) Maximum item of the array: {FindMaxItemInArray(arr)}");
            Console.WriteLine($"3) Index of the maximum element of the array: {FindMaxIdItemInArray(arr)}");
            Console.WriteLine($"4) Maximum item of the array by modulus: {FindMaxAbsItemInArray(arr)}");
            Console.WriteLine($"5) Sum of indexes positive numbers of the array: {SumOfIndexesPositiveElementsInArray(arr)}");
            Console.WriteLine($"6) Count of the integer numbers of the array: {FindCountIntegerNumbersInArray(arr)}");
        }

        static void FillArray(double[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = ConsoleReader.ReadDouble($"{i + 1}th item");
            }
        }

        static string ArrayToString(double[] array)
        {
            var result = "Array = {  ";

            foreach (var item in array)
            {
                result += $"{item}  ";
            }

            result += "}";
            return result;
        }

        static double FindMaxItemInArray(double[] arr)
        {
            var max = double.MinValue;
            foreach (var item in arr)
            {
                if (item > max)
                {
                    max = item;
                }
            }

            return max;
        }

        static double FindMaxAbsItemInArray(double[] arr)
        {
            var max = double.MinValue;
            foreach (var item in arr)
            {
                if (Math.Abs(item) > max)
                {
                    max = item;
                }
            }

            return max;
        }

        static double FindMaxIdItemInArray(double[] arr)
        {
            var maxId = 0;

            var max = double.MinValue;
            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    maxId = i;
                }
            }

            return maxId;
        }

        static int FindCountIntegerNumbersInArray(double[] arr)
        {
            var counter = 0;

            foreach (var item in arr)
            {
                if (item - Math.Truncate(item) == 0)
                {
                    counter++;
                }
            }

            return counter;
        }

        static double SumOfNegativeElementsInArray(double[] arr)
        {
            var sum = 0.0;

            foreach (var item in arr)
            {
                if (item < 0)
                {
                    sum += item;
                }
            }

            return sum;
        }

        static int SumOfIndexesPositiveElementsInArray(double[] arr)
        {
            var sum = 0;

            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}