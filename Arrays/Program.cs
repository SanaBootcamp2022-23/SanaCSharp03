Console.WriteLine("Enter size of array: ");
int sizeN = int.Parse(Console.ReadLine()),
    countInteger = 0;
double[] array = new double[sizeN];
double sumaOfNegatives = 0, 
    maxElement, 
    indexMaxElement = 0, 
    maxAbsoluteValue = array[0],
    smallestValue = 0,
    sumaIndexOfPositives = 0;
bool includeNegatives = false;
//пошук суми від’ємних елементів масиву
for (int i = 0;i < sizeN;i++) 
{
    Console.WriteLine($"Enter {i} element: ");
    array[i] = double.Parse(Console.ReadLine());
    if (array[i] < 0)
    {
        sumaOfNegatives += array[i];
        includeNegatives = true;
    }
}
//пошук максимального елементу та його індексу
maxElement = array[0]; 
    for (int i = 0; i < sizeN; i++)
    {
        if (maxElement < array[i])
        {
            maxElement = array[i];
            indexMaxElement = i;
        }
    }
//пошук максимального за модулем елементу
if (includeNegatives == false)
    maxAbsoluteValue = maxElement;
for (int i = 0; i < sizeN; i++)
    {
        if (smallestValue > array[i])
            smallestValue = array[i];
    }
smallestValue *= -1;
if (smallestValue <= maxElement)
    maxAbsoluteValue = maxElement;
else
    maxAbsoluteValue = smallestValue;
//пошук суми індексів додатніх елементів
for(int i = 0;i < sizeN; i++)
{
    if (array[i] > 0)
    {
        sumaIndexOfPositives += i;
    }
}
//пошук кількості цілих чисел
for(int i = 0;i < sizeN; i++)
{
    if (array[i] % 1 == 0) 
    {
        countInteger++;
    }
}
Console.WriteLine($"\n\nSum of negative numbers = {sumaOfNegatives}");
Console.WriteLine("Max element = " + maxElement + " has index " + indexMaxElement);
Console.WriteLine("Max absolute value = " + maxAbsoluteValue);
Console.WriteLine("Sum of positive numbers index = " + sumaIndexOfPositives);
Console.WriteLine("Total integer in array: " + countInteger);