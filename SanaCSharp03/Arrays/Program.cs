using System;

int count;
Console.Write("Please, enter the size of the array \"n\" = ");
while (!int.TryParse(Console.ReadLine(), out count) || count <= 0) ;
double[] arr = new double[count];
double sumNegativeElement = 0;
double maxElement = double.MinValue;
int indexOfMaxElement = 0;
double maxModuleElement = 0;
double sumOfIndexPositivElement = 0;
int allIntegerElement = 0;
Random random = new Random();
for (int i = 0; i < count; i++)
{
    arr[i] = random.Next(-100, 100) + random.Next(0, 9) / 10.0;
    if (arr[i] < 0)
    {
        sumNegativeElement += arr[i];
    }
    if (arr[i] > maxElement)
    {
        maxElement = arr[i];
        indexOfMaxElement = i;
    }
    if (Math.Abs(arr[i]) > Math.Abs(maxModuleElement))
        maxModuleElement = arr[i];
    if (arr[i] > 0)
    {
        sumOfIndexPositivElement += i;
    }
    if (arr[i] == (int)arr[i])
    {
        allIntegerElement++;
    }
}
foreach (double value in arr)
    Console.Write($"{value} ");
Console.WriteLine($"\nSum of all negative elements in array is: {sumNegativeElement}");

Console.WriteLine($"Maximum element of the array is: {maxElement} and its index is: {indexOfMaxElement}");

Console.WriteLine($"Maximum element of the array by module: {maxModuleElement}");

Console.WriteLine($"The sum of indexes of positive array elements is: {sumOfIndexPositivElement} ");

Console.WriteLine($"Number of integers in the array is: {allIntegerElement} ");