// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;
Console.Write("Введіть кількість чисел: ");
int neg = 0, maxElement = 0, index = 0, maxModul = 0, sumIndex =0, countIndex = 0;
int count = int.Parse(Console.ReadLine());
int[] arr = new int[count];

for (int i = 0; i < count; i++)
{
    Console.WriteLine($"Число {i + 1} = ");
    arr[i] = int.Parse(Console.ReadLine());
    if (arr[i] < 0)
    {
         neg += arr[i];
    }
    if(maxElement < arr[i])
    {
        maxElement = arr[i];
        index = i;
    }
    if (Math.Abs(maxModul) < Math.Abs(arr[i]))
    {
        maxModul = arr[i];
    }

    if (arr[i] > 0)
    {
        sumIndex += i;
    }

    if (arr[i] % 1 == 0)
    {
        countIndex++;
    }



}
Console.WriteLine("Сума відємних елементів масиву: " + neg);
Console.WriteLine("Максималний елемент масиву: " + maxElement);
Console.WriteLine("індекс максимального елементу масиву: " + index);
Console.WriteLine("Максималний елемент масиву по модулю: " + maxModul);
Console.WriteLine("Сума індексів лодатніх елемментів: " + sumIndex);
Console.WriteLine("кількість цілих чисел у масиві: " + countIndex);
