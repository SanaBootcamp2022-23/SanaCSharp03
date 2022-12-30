using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using System.Xml.Linq;
using static System.Math;

namespace SanaCSharp03
{
    class Program
    {
        private static double а;

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = UTF8Encoding.UTF8;
            Console.WriteLine("  Масиви");
            Console.Write("  Введіть розмірність масиву: ");
            int count = int.Parse(Console.ReadLine());
            if (count < 0)
            {
                Console.WriteLine("\n  К-сть елементів не може бути менше 0\n");
                return;
            }
            Console.WriteLine("\n Заповнюємо масив: \n");
            int[] arr = new int[count];
            for (int i = 0; i < count; i++)
            {
                Console.Write($"  arr[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("\n  Вивід масиву\n");
            for (int i = 0; i < count; i++)
                Console.Write($"  {arr[i]}  ");


            int sumOfTheNegativeElements = 0;
            for (int i = 0; i < count; i++)
            {
                if (arr[i] < 0)
                {
                    sumOfTheNegativeElements += arr[i];
                }
            }
            Console.Write($"\n\n  Сума від'ємних елементів масиву: {sumOfTheNegativeElements}\n");

            int max = arr[0]; int index = 0;
            for (int i = 0; i < count; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    index = i;
                }
            }
            Console.Write($"  Максимальний клкмент даного масиву: {max}\n");
            Console.Write($"  Індекс максимального елементу масиву: {index}\n");


            int maxmodul = Math.Abs(arr[0]);
            for (int i = 0; i < count; i++)
            {
                if (Math.Abs(arr[i]) > maxmodul) 
                {
                    maxmodul = Math.Abs(arr[i]);
                }
            }
            Console.Write($"  Найбільший елемент масиву за модулем: {maxmodul}\n");


            int index_Sum = 0;
            for (int i = 0; i < count; i++)
            {
                if (arr[i] > 0)
                {
                    index_Sum += i;
                }
            }
            Console.Write($"  Сума індексів парних елементів: {index_Sum}\n\n");


            int countIntElements = 0;
            for (int i = 0; i < count; i++)
            {
                countIntElements++;   //масив і так з елементів цілого типу даних
            }
            Console.WriteLine($"  Кількість цілих елементіів: {countIntElements}\n\n");
        }
    }
}