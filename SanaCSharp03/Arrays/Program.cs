using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = GetArrayLength();
            double[] array = GetDoubleArray(size);
            Console.WriteLine("\nArray: ");
            foreach(var item in array)
                Console.Write(item + " ");

            int maxElemIndex = 0, posElemIndexSum = 0, intElemCount = 0;
            double negElemSum = 0,maxElem = array[0], maxAbsElem = Math.Abs(array[0]);
            for(int i = 0; i < array.Length; i++)
            {
                // 1 
                if (array[i] < 0)
                    negElemSum += array[i];

                // 2, 3, 4
                if (i > 0)
                {
                    if (array[i] > maxElem)
                    {
                        maxElem = array[i];
                        maxElemIndex = i;
                    }
                    if (Math.Abs(array[i]) > maxAbsElem)
                        maxAbsElem = Math.Abs(array[i]);
                }

                //5
                if (array[i] > 0)
                    posElemIndexSum += i;

                //6
                if (array[i] % 1 == 0)
                    intElemCount++;

            }

            Console.WriteLine($"\nNegative elements sum: {negElemSum}\n" +
                $"Max element: {maxElem}\n" +
                $"Max elem index: {maxElemIndex}\n" +
                $"Max absolute element: {maxAbsElem}\n" +
                $"Positive elements index sum: {posElemIndexSum}\n" +
                $"Amount of int numbers: {intElemCount}");
            Console.ReadLine();
        }

        public static int GetArrayLength()
        {
            int size = 0;
            do
            {
                Console.Write("Enter the size of the array: ");
                if (!int.TryParse(Console.ReadLine(), out size) || size < 1)
                {
                    Console.WriteLine("Input error! Try again!");
                    continue;
                }
                else
                    break;
                
            } while (true);
            return size;
        }

        public static double[] GetDoubleArray(int size)
        {
            double[] array = new double[size];
            for (int i = 0; i < size; i++)
            {
                do
                {
                    Console.Write($"Enter the {i + 1} element of the array: ");
                    if (!double.TryParse(Console.ReadLine(), out array[i]))
                    {
                        Console.WriteLine("Input error! Try again!");
                        continue;
                    }
                    else
                        break;
                }
                while (true);

            }
            return array;
        }
    }
}
