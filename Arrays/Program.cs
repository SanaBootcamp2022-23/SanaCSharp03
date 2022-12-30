using System.Xml.Linq;
using System;

Console.WriteLine("Enter the value of n (the number of elements in the array)");
int n = int.Parse(Console.ReadLine());
double[] a = new double[n];

double sumv = 0, max = a[0], mmax = Math.Abs(a[0]);
int imax = 0, immax = 0, idsum = 0, count = 0;

for (int i = 0; i < n; i++)
{
    Console.Write($"Enter value of {i + 1} element: ");
    a[i] = double.Parse(Console.ReadLine());
}

for (int i = 0; i < n; i++)
{
    if (a[i] < 0)
        sumv += a[i];
    if (a[i] > max)
    {
        max = a[i];
        imax = i;
    }
    if (Math.Abs(a[i]) > mmax)
    {
        mmax = Math.Abs(a[i]);
        immax = i;
    }
    if (a[i] > 0)
    {
        idsum += i;
    }
    if (Convert.ToInt32(a[i]) == Convert.ToDouble(a[i]))
        count++;
    }

    Console.WriteLine("Sum of negative array elements: {0}\n", sumv);
    Console.WriteLine("Maximum array element value: {0}\n", max);
    Console.WriteLine("Index of the maximum array element: {0}\n", imax);
    Console.WriteLine("Maximum absolute value of an array element: {0}\n", a[immax]);
    Console.WriteLine("Sum of indices of positive elements: {0}\n", idsum);
    Console.WriteLine("Number of integers in array: {0}\n", count);