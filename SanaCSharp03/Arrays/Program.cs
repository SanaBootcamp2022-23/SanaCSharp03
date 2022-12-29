using System;
using System.Text;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // для української розкладки
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            //кому на крапку
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            //створення і заповнення вручну
            int count;

            Console.Write("Please,input a size num of array : ");

            count = int.Parse(Console.ReadLine());

            double[] array = new double[count];

            for(int i = 0; i < count; i++)
            {
                Console.Write($"Input arr[{i}] : ");
                array[i] = double.Parse(Console.ReadLine());
            }

            //вивід масиву для наглядності

            Console.Write("Array looks like : ");
            for (int i = 0; i < count; i++)
            {
                Console.Write($"| {array[i]} |");
            }

            //сума від’ємних елементів масиву

            double summOfNeganitve = 0;

            for (int i = 0; i < count; i++)
            {
                if (array[i] < 0)
                {
                    summOfNeganitve += array[i];
                }
            }
            Console.Write($"\nСумма від'ємних значень: {summOfNeganitve}");

            //максимальний елемент масиву + номер (індекс) максимального елемента масиву

            double tempForMaximum = array[0];
            int tempForIndexOfMax = 0;

            for (int i = 0; i < count; i++)
            {
                if (array[i] > tempForMaximum)
                {
                    tempForMaximum = array[i];
                    tempForIndexOfMax = i;
                }
            }
            Console.Write($"\nМаксимальне число в масиві: {tempForMaximum}");
            Console.Write($"\nІндекс максимального числа в масиві: {tempForIndexOfMax}");

            //максимальний за модулем елемент масиву;

            double AbsMax = Math.Abs(array[0]);

            for (int i = 0; i < count; i++)
            {
                if (Math.Abs(array[i]) > AbsMax)
                {
                    AbsMax = Math.Abs(array[i]);
                }
            }
            Console.Write($"\nМаксимальний за модулем елемент масиву: {AbsMax}");

            //суму індексів додатних елементів

            int tempForIndexSummary = 0;

            for (int i = 0; i < count; i++)
            {
                if (array[i]>0)
                {
                    tempForIndexSummary += i;
                }
            }
            Console.Write($"\nCума індексів додатних елементів: {tempForIndexSummary}");

            //кількість цілих чисел у масиві

            int tempForAmmountOfInt = 0;
            for (int i = 0; i < count; i++)
            {
                if (array[i] == 0 || array[i] % (int)array[i] == 0)
                {
                    tempForAmmountOfInt++;
                }
            }
            Console.WriteLine($"\nКількість цілих чисел у масиві: {tempForAmmountOfInt}");

        }
    }
}
