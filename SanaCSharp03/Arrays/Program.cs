using System;
using System.Text;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            int max = 0,min=0,sum = 0,sumMin=0;
            Console.WriteLine("Введіть кількість елементів масиву");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int m = arr[0];
            for (int i = 0; i < arr.Length; i++) {
                Console.Write($"Введіть елемент масиву під індексом {i}: "); 
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {   
                if (arr[i] > m)
                {
                    m = arr[i];
                } 
                if (arr[i] > max)//сума додатніх елементів
                {
                    max++;
                    sum += arr[i];
                } 
                else // сума від'ємних елементів
                {
                    min++;
                    sumMin += arr[i];
                }
                    
                Console.Write($" {arr[i]} ");
            }
            Console.Write("]\n");
            Console.WriteLine($"Кількість від'ємних чисел {min}" +
                $"\nКількість додатніх чисел : {max}" +
                $"\nСума від'ємних чисел :{sumMin}" +
                $"\nМаксимальний елемент масиву {arr.Max()}, індекс :{Array.IndexOf(arr, arr.Max())}" +
                $"\nМаксимальний елемент по модулю :{m}" +
                $"\nСума індексів додатніх елементів :{sum}");
        }
    }
}
