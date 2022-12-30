using System;
using System.Text;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

Console.Write("Введіть N (N - кількість елементів масиву): ");

int n = int.Parse(Console.ReadLine());

double[] arr = new double[n];

int indexOfMax = 0, indexOfAbs = 0, posIndexSum = 0, integer = 0;
double sumOfNegative = 0, max = arr[indexOfMax], maxAbsolute = arr[indexOfAbs];

Random rand = new Random();

Console.Write("Отриманий масив: ");

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(-1000, 1000) / 10.0;

    Console.Write(arr[i] + "; ");

    if (arr[i] < 0)
    {
        sumOfNegative += arr[i];
    }

    if (arr[i] >= max)
    {
        max = arr[i];
        indexOfMax = i;
    }

    if (Math.Abs(arr[i]) >= maxAbsolute)
    {
        maxAbsolute = Math.Abs(arr[i]);
        indexOfAbs = i;
    }

    if (arr[i] > 0)
    {
        posIndexSum += i;
    }

    if (arr[i] % 1 == 0)
    {
        integer++;
    }
}

Console.WriteLine($"\nСума від’ємних елементів масиву: {sumOfNegative}"); 
Console.WriteLine($"Максимальний елемент масиву: {max}");
Console.WriteLine($"Індекс максимального елемента масиву: {indexOfMax}");
Console.WriteLine($"Максимальним елементом за модулем масиву є |{arr[indexOfAbs]}| = {maxAbsolute}");
Console.WriteLine($"Сума індексів додатніх елементів: {posIndexSum}");
Console.WriteLine($"Кількість цілих чисел у масиві: {integer}");






