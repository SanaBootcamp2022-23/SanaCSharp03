using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть кiлькiсть елементiв: ");

            var n = int.Parse(Console.ReadLine());
            double[] array = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введiть {i + 1} елемент масиву: ");
                array[i] = double.Parse(Console.ReadLine());
            }

            double negativeSum = 0,
                maxElement = array[0],
                maxModuleElement = Math.Abs(array[0]);
            int maxElementIndex = 0,
                positiveElementsIndexSum = 0,
                integerElementsCount = 0;

            for (int i = 0; i < n; i++)
            {
                if (array[i] < 0)
                    negativeSum += array[i];

                if (maxElement < array[i])
                {
                    maxElement = array[i];
                    maxElementIndex = i;
                }

                if (maxModuleElement < Math.Abs(array[i]))
                    maxModuleElement = array[i];

                if (array[i] > 0)
                    positiveElementsIndexSum += i;

                if (array[i] % 1 == 0)
                    integerElementsCount++;
            }

            Console.WriteLine($"\nСума вiд’ємних елементiв масиву = {negativeSum}");
            Console.WriteLine($"Максимальний елемент масиву = {maxElement}");
            Console.WriteLine($"Iндекс максимального елемента масиву = {maxElementIndex}");
            Console.WriteLine($"Максимальний за модулем елемент масиву = {maxModuleElement}");
            Console.WriteLine($"Cума iндексiв додатнiх елементiв = {positiveElementsIndexSum}");
            Console.WriteLine($"Кiлькiсть цiлих чисел у масивi = {integerElementsCount}");
        }
    }
}
