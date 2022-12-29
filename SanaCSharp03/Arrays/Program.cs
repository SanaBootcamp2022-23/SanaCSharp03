// See https://aka.ms/new-console-template for more information
//SanaCShapr03
//Bohdan Serdeniuk

using System.Linq;

Console.WriteLine("enter number of array elements - ");
uint numberOfArrayElements = uint.Parse(Console.ReadLine());
int[] array = new int[numberOfArrayElements];

int sumOfNegativeValues = 0;
int maxValueOfArray;
uint maxValueArrayIndex = 0;
int maxValueByModulus = 0;
uint sumOfIndexWithPositiveValues = 0;

uint countOfMaxValueIndex = 1;
uint[] arrayOfMaxValueIndex;
uint n = 0;

//array initialization 
for (int i = 0; i < numberOfArrayElements; i++)
{
    Console.WriteLine($"enter value of {i} element");
    array[i] = int.Parse(Console.ReadLine());
}

//array data processing
maxValueOfArray = array[0];                                                                 //issue avoidance when all array values ​​are negative

for (uint i = 0; i < numberOfArrayElements; i++)
{
    if (array[i] < 0)
        sumOfNegativeValues += array[i];

    if (array[i] >= maxValueOfArray)
    {
        maxValueOfArray = array[i];
        maxValueArrayIndex = i;
    }

    for (uint j = maxValueArrayIndex+1; j < numberOfArrayElements ; j++)
    {
        if (array[j] == maxValueOfArray)
        {
            countOfMaxValueIndex++;
        }
    }
    /*arrayOfMaxValueIndex = new uint[countOfMaxValueIndex];
    
    for (uint j = maxValueArrayIndex + 1; j < numberOfArrayElements; j++)
    {
        if (array[j] == maxValueOfArray)
        {   
            arrayOfMaxValueIndex[n] = j;
            n++;
            Console.WriteLine("[{0}]", string.Join(", ", arrayOfMaxValueIndex));
        }
    }*/

    if (Math.Abs(array[i]) > Math.Abs(maxValueByModulus))
    {
        maxValueByModulus = array[i];
    }

    if (array[i] > 0)
        sumOfIndexWithPositiveValues += i;
}

arrayOfMaxValueIndex = new uint[countOfMaxValueIndex];

<<<<<<< HEAD
for (uint j = maxValueArrayIndex + 1; j < numberOfArrayElements; j++)
=======
for (uint j = maxValueArrayIndex ; j < numberOfArrayElements; j++)
>>>>>>> beckupAndUpdate
{
    if (array[j] == maxValueOfArray)
    {
        arrayOfMaxValueIndex[n] = j;
        n++;
    }
}
Console.WriteLine("[{0}]", string.Join(", ",arrayOfMaxValueIndex));


//outputting results
Console.WriteLine("\nresults:");
if (sumOfNegativeValues < 0)
    Console.WriteLine($"1. sum of negative array elements = {sumOfNegativeValues}");
else
    Console.WriteLine("1. array does not contain negative values");

Console.WriteLine($"2. maximum element of the array = {maxValueOfArray}");
Console.WriteLine($"3. index of the maximum element of the array = {maxValueArrayIndex}");
Console.WriteLine($"4. maximum element of the array by modulus = {maxValueByModulus}");
Console.WriteLine($"5. sum of indices of positive elements = {sumOfIndexWithPositiveValues}");

////////////////////////////////////////////////////////////////////////////////////////////////////////
//3. подумати про випадок коли 2+ числа мають максимальне значення
//3. вивести масив індексів значень з максимальним значенням
/* 
    створити масив
    прогнати цикл (від індексу найбільшого елементу; якщо значення елементу == значенню найбільшого елементу; і++)
    записати в масив значення індексу

    дати на виведення всі значення масиву
 */

//3. подумати про indexOf