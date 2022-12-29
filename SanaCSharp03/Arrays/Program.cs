using System.Text;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            ushort n;
            bool isOk;
            do
            {
                Console.Write("Введіть розмір масиву: ");
                isOk = ushort.TryParse(Console.ReadLine(), out n);
                if (!isOk || n <= 0)
                    Console.WriteLine("Ви помилилися при введені! Спробуйте ще!");
            } while (!isOk || n <= 0);
            double[] arr = new double[n];
            Random random = new Random();
            const int minValue = -1000, maxValue = 1001;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(minValue, maxValue) / 10.0;
                Console.WriteLine(arr[i]);
            }
            int maxElementIndex, sumOfPositiveNumbersIndex = 0, countOfIntegersInArray = 0;
            double sumOfNegativeNumbers = 0, maxElementOfArray, maxAbsElementOfArray;
            maxElementOfArray = arr[0];
            maxAbsElementOfArray = arr[0];
            maxElementIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxElementOfArray)
                {
                    maxElementOfArray = arr[i];
                    maxElementIndex = i;
                }
                if (Math.Abs(arr[i]) > Math.Abs(maxAbsElementOfArray))
                    maxAbsElementOfArray = arr[i];
                if (arr[i] % 1 == 0)
                    countOfIntegersInArray++;
                if (arr[i] > 0)
                    sumOfPositiveNumbersIndex += i;
                if (arr[i] < 0)
                    sumOfNegativeNumbers += arr[i];
            }
            Console.WriteLine($"Сума від’ємних елементів масиву: {sumOfNegativeNumbers}");
            Console.WriteLine($"Максимальний елемент масиву: {maxElementOfArray}");
            Console.WriteLine($"Індекс максимального елемента масиву: {maxElementIndex}");
            Console.WriteLine($"Максимальний за модулем елемент масиву: {maxAbsElementOfArray}");
            Console.WriteLine($"Сума індексів додатних елементів: {sumOfPositiveNumbersIndex}");
            Console.WriteLine($"Кількість цілих чисел у масиві: {countOfIntegersInArray}");
        }
    }
}