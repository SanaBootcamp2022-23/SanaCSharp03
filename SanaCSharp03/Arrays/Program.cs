int count;
Console.WriteLine("n= ");
count = int.Parse(Console.ReadLine());
if (count <= 0)
{
    Console.WriteLine("Error! n < 0");
    return;

}
double summaNegatives = 0;
double maxValue = double.MinValue;
int maxIndex = 0;
double maxAbsValue = double.MinValue;
int maxAbsIndex = 0;
int summaIndex = 0;
int integerCount = 0;
double[] array = new double[count];
for (int i = 0; i < count; i++)
{
    Console.Write($"array[{i}] = ");
    array[i] = double.Parse(Console.ReadLine());
    if (array[i] < 0)
        summaNegatives += array[i];
    if (array[i] > maxValue)
    {
        maxValue = array[i];
        maxIndex = i;
    }
    if (Math.Abs(array[i]) > maxAbsValue)
    {
        maxAbsValue = Math.Abs(array[i]);
        maxAbsIndex = i;
    }
    if (array[i] > 0)
        summaIndex += i;
    if (array[i] % 1 == 0)
        integerCount++;


}
Console.WriteLine($"summaNegatives = {summaNegatives}");
Console.WriteLine($"maxValue = {maxValue}");
Console.WriteLine($"maxIndex = {maxIndex}");
Console.WriteLine($"maxAbsValue = {array[maxAbsIndex]}");
Console.WriteLine($"summaIndex = {summaIndex}");
Console.WriteLine($"integerCount = {integerCount}");


