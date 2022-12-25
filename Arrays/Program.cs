using System;
using System.Linq;

namespace Arrays {
    public class Program {
        public static void Main(String[] args) {
            int arraySize = GetPositiveNumberFromUser("Enter array size: ");
            double[] array = GetRandomDoubleArray(arraySize, -10, 10);

            Console.WriteLine("Array: " + "[" + string.Join(", ", array) + "]\n");

            double sumOfNegativeElements = array.Where(number => number < 0)
                                                .Sum();

            double maxElement = array.Max();

            int indexOfMaxElement = array.ToList()
                                         .IndexOf(maxElement);

            double maxElementByAbsoluteValue = array.Max(number => Math.Abs(number));

            int sumOfIndexesOfPositiveElements = array.Select((element, index) => element > 0 ? index : 0)
                                                      .Sum();

            int numberOfIntegers = array.Count(number => number == (double) Math.Round(number));


            Console.WriteLine("Sum of negative elements: " + sumOfNegativeElements);
            Console.WriteLine("Max element: " + maxElement);
            Console.WriteLine("Index of max element: " + indexOfMaxElement);
            Console.WriteLine("Max element by absolute value: " + maxElementByAbsoluteValue);
            Console.WriteLine("Sum of indexes of positive elements: " + sumOfIndexesOfPositiveElements);
            Console.WriteLine("Number of integers: " + numberOfIntegers);
        }

        public static double[] GetRandomDoubleArray(int arraySize, double start, double stop) {
            double[] randomDoubleArray = new double[arraySize];
            Random random = new Random();

            for (int i = 0; i < arraySize; ++i) {
                randomDoubleArray[i] = Math.Round(
                        random.NextDouble() * (stop - start) + start, 3);
                // Make several integers inside array
                if (random.Next(0, 5) == 1)
                    randomDoubleArray[i] = Math.Round(randomDoubleArray[i]);
            }

            return randomDoubleArray;
        } 

        public static int GetPositiveNumberFromUser(string message) {
            int positiveNumber;

            Console.Write(message);
            while (true) {
                if (!int.TryParse(Console.ReadLine(), out positiveNumber)) {
                    Console.Write("Error! Not a number. Try again: ");
                    continue;
                }
                if (positiveNumber <= 0) {
                    Console.Write("Error! Your number is negative or equal to zero. Try again: ");
                    continue;
                }
                return positiveNumber;
            }
        }
    }
}
