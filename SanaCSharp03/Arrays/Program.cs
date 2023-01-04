using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool isOk;
            do
            {
                Console.Write("Enter len of arr: ");
                isOk = int.TryParse(Console.ReadLine(), out n);
                if (!(isOk && n > 0))
                    Console.WriteLine("Error!");

            } while (!(isOk && n > 0));

            double[] arr = new double[n];
            Random random = new Random();

            double sumNegElem = 0;
            double maxElem = 0;
            double maxModuleElem = 0;
            int indexMaxElem = 0;
            int sumIndexPosElem = 0;
            int countIntElem = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Math.Round(random.NextDouble() * 100 - 60, 3);
                // суму від’ємних елементів масиву
                if (arr[i] < 0)
                {
                    sumNegElem += arr[i];
                }

                // максимальний елемент масиву;
                //номер (індекс) максимального елемента масиву;
                if (arr[i] > maxElem)
                {
                    maxElem = arr[i];
                    indexMaxElem = i;
                }

                // максимальний за модулем елемент масиву;
                if (Math.Abs(arr[i]) > maxModuleElem)
                {
                    maxModuleElem = Math.Abs(arr[i]);
                }

                //суму індексів додатних елементів;
                if (arr[i] > 0)
                {
                    sumIndexPosElem += i;
                }

                //кількість цілих чисел у масиві.
                if (arr[i] % 1 == 0)
                {
                    countIntElem++;
                }
                Console.WriteLine(arr[i]);

            }
            Console.WriteLine($"\tResults: \n" +
                $"1. Sum of negative elements: {sumNegElem}\n" +
                $"2. Max element: {maxElem}\n" +
                $"3. Index of max element: {indexMaxElem}\n" +
                $"4. Max element by module: {maxModuleElem}\n" +
                $"5. Sum of indexes positive elements: {sumIndexPosElem}\n" +
                $"6. Count of int elements: {countIntElem}");
        }
    }
}
