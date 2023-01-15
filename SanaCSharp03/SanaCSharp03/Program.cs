using System;

namespace myApp
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            int n, sumIndex = 0, countInt = 0;
            double sumNeg = 0, indexMax = 0, maxModule = 0;
            Console.Write("Введіть к-ість елементів масиву: ");
            n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("Помилка! Кількість елементів не може бути менша нуля!");
                return;
            }
            double[] arr = new double[n];
            double maxelement = arr[0];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"\tВведіть елемент масиву [{i}]: ");
                arr[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    sumNeg += arr[i];
                }
                if (arr[i] > maxelement)
                {
                    maxelement = arr[i];
                    indexMax = i;
                }
                if (Math.Abs(arr[i]) > maxModule)
                {
                    maxModule = Math.Abs(arr[i]);
                }
                if (arr[i] > 0)
                {
                    sumIndex += i;
                }
                if (arr[i] % 1 == 0)
                {
                    countInt++;
                }
            }
            Console.WriteLine(" Масив: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine($"\n Сума від'ємних елементів масиву: {sumNeg}");
            Console.WriteLine($"\nМаксимальний елемент масиву = {maxelement}, його індекс  -> [{indexMax}]");
            Console.WriteLine($"\n Максимальний за модулем елемент масиву: {maxModule}");
            Console.WriteLine($"\n Сума індексів додатніх елементів: {sumIndex}");
            Console.WriteLine($"\n К-ість цілих чисел: {countInt}");
        }
    }
}
