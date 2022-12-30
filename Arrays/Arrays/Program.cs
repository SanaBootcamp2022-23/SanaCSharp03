using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введiть розмiр масиву:");
            n = int.Parse(Console.ReadLine());
            double[] mass = new double[n];
            Console.WriteLine("Введіть числа:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Число {i + 1}=");
                mass[i] = int.Parse(Console.ReadLine());
            }
            int summIndexPositive = 0, countWholeNumb = 0;
            double minus = 0, maxEl = mass[0], maxModuleEl = Math.Abs(mass[0]), indexMaxEl = 0;
            for (int i = 0; i < n; i++)
            {
                if (mass[i] < 0)
                {
                    minus += mass[i];
                }
                if (maxEl < mass[i])
                {
                    maxEl = mass[i];
                    indexMaxEl = i;
                }
                if (maxEl < Math.Abs(mass[i]))
                {
                    maxModuleEl = mass[i];

                }
                if (mass[i] > 0)
                {
                    summIndexPositive += i;
                }
                if (Math.Abs(mass[i]) % 1 == 0)
                {
                    countWholeNumb++;
                }
            }
            Console.WriteLine($"Сума вiд'ємних елементiв: {minus}\n");
            Console.WriteLine($"Mаксимальний елемент масиву: {maxEl}\n");
            Console.WriteLine($"Iндекс максимального елемента масиву: {indexMaxEl}\n");
            Console.WriteLine($"Mаксимальний за модулем елемент масиву: {maxModuleEl}\n");
            Console.WriteLine($"Cуму iндексiв додатних елементiв: {summIndexPositive}\n");
            Console.WriteLine($"Kiлькiсть цiлих чисел у масив: {countWholeNumb}\n");
            
        }
    }
}
