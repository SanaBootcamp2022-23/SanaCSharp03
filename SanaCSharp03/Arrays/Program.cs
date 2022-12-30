using System.Security.Cryptography;
using System;

double[] arr = new double[50];
double sumNeg = 0, max = -100, index = 0, maxAbs = -100, sumPos = 0, amountInt = 0;
Random random = new Random();
Console.WriteLine("Enter amount of numbers in array:");
int n = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Array:");
for (int i = 0; i < n; i++)
{
    arr[i] = random.NextDouble() * (20 - (-20)) + (-20);
    Console.Write(string.Format("{0:F2}  ", arr[i]));
}
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    if (arr[i] < 0) sumNeg += arr[i];
    if (arr[i] > max)
    {
        max = arr[i];
        index = i;
    }
    if (Math.Abs(arr[i]) > maxAbs) maxAbs = arr[i];
    if (arr[i] > 0) sumPos += i;
    if (arr[i] % 1 == 0) amountInt++;
}
Console.Write($"SumOfNeg:{sumNeg}\nMax:{max}\nIndexOfMax:{index}\nMaxAbs:{maxAbs}\nSumOfPosIndex:{sumPos}\nAmountOfIntNums:{amountInt}");
