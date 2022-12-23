int length, maxi = 0, isum = 0, integercount = 0;
double negativelementsum = 0, max = 0, maxabs = 0;
Console.Write("Array length = ");
length = int.Parse(Console.ReadLine());
if (length < 1)
{
    Console.WriteLine("Error! Array length zero or negative not acceptable!");
    return;
}
double[] array = new double[length];
for (int i = 0; i < length; i++)
{
    Console.Write($"Array[{i}] = ");
    array[i] = double.Parse(Console.ReadLine());
}
for (int i = 0; i < length; i++)
{
    if (array[i] < 0)
        negativelementsum += array[i];
    if (array[i] > max)
    {
        max = array[i];
        maxi = i;
    }
    if ((Math.Abs(array[i])) > maxabs)
        maxabs = array[i];
    if (array[i] > 0)
        isum += i;
    if (array[i] % 1 == 0)
        integercount++;
}
Console.WriteLine($"Sum of negative elements of the array = {negativelementsum}");
Console.WriteLine($"Max element of the array = {max} at index {maxi}");
Console.WriteLine($"Max element of the array by absolute value = {maxabs}");
Console.WriteLine($"Sum of positive elements' indexes of the array = {isum}");
Console.WriteLine($"Count of integer numbers in the array = {integercount}");