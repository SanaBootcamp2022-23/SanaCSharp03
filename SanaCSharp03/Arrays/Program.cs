using System;

int count;
Console.Write("Please, enter the size of the array \"n\" = ");
count = int.Parse(Console.ReadLine());

int[] arr = new int[count];

int sumNegativeElem = 0;
double maxElem = arr[0];
int indexOfMaxElem = 0;
double maxModuleElem = 0;
double sumOfIndexPositivE = 0;
int allInteger = 0;

Console.WriteLine("Enter the whole array elements: ");
for (int i = 0; i < count; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}

// сума від’ємних елементів масиву
for (int i = 0; i < count; i++)
{
   if (arr[i]<0)
    {
        sumNegativeElem += arr[i];
    }
}
Console.WriteLine($"Sum of all negative elements in array is: {sumNegativeElem}");

// максимальний елемент масиву та його номер
for (int i = 0; i < count; i++)
{
    if (arr[i] > maxElem)
    {
        maxElem = arr[i];
        indexOfMaxElem = i;
    }
}
Console.WriteLine($"Maximum element of the array is: {maxElem} and its index is: {indexOfMaxElem}");

// максимальний за модулем елемент масиву
for (int i = 0; i < count; i++)
{ 
    if (Math.Abs(arr[i]) > Math.Abs(maxModuleElem))
        maxModuleElem = arr[i];
}
Console.WriteLine($"Maximum element of the array by module: {maxModuleElem}");


// сума індексів додатних елементів
for (int i = 0; i < count; i++)
{
   if (arr[i] > 0)
    {
        sumOfIndexPositivE += i;
    }
}
Console.WriteLine($"The sum of indexes of positive array elements is: {sumOfIndexPositivE} ");

// кількість цілих чисел у масиві
for (int i = 0; i < count; i++)
{
    if (arr[i] == arr[i])
    {
        allInteger++;
    }
}
Console.WriteLine($"Number of integers in the array is: {allInteger} ");