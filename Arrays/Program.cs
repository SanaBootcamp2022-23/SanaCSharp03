int count;
Console.Write("n = ");
count = int.Parse(Console.ReadLine());
double sumOfNegative = 0;
double[] array = new double[count];
double maxArrayValue = array[0];
double minArrayValue = array[0];
double sumOfIndexes = 0;
double maxAbsValue = 0;
double amountOfInteger = 0;

for (int i = 0; i < count; i++)
{
    Console.Write($"Input array element[{i}] = ");
    array[i] = double.Parse(Console.ReadLine());

    if (array[i] < 0)    
        sumOfNegative += array[i];
    
    if (array[i] > maxArrayValue)    
        maxArrayValue = array[i];
    
    if (array[i] < minArrayValue)   
        minArrayValue = array[i];
    
    if (Math.Abs(array[i]) > maxAbsValue)    
        maxAbsValue = Math.Abs(array[i]);
    
    if (array[i] > 0)
        sumOfIndexes += i;
    
    if (array[i] % 1 == 0)
        amountOfInteger++;           
}

Console.WriteLine($"Max array value = {maxArrayValue}");
Console.WriteLine($"Max array value index = {Array.IndexOf(array, maxArrayValue)}");
Console.WriteLine($"Max absolute value of element in an array = {maxAbsValue}");
Console.WriteLine($"Sum of indexes of positive elements in an array = {sumOfIndexes}");
Console.WriteLine($"Sum of negative elements in an array = {sumOfNegative}");
Console.WriteLine($"Amount of integers in an array = {amountOfInteger}");

