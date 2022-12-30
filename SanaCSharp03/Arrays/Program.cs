// See https://aka.ms/new-console-template for more information

int N;
Console.Write("Enter N = "); N = int.Parse(Console.ReadLine());
double[] array = new double[N];
var rand = new Random();

Console.WriteLine("\nStart array");

for (int i = 0; i < N; i++)
{
    array[i] = rand.Next(-10, 10);
    Console.Write($" {array[i]} ");
}
Console.WriteLine("");

double minissum = 0;

for (int i = 0; i < N; i++)
{
    if (array[i] < 0)
    {
        minissum += array[i];
    }
}

Console.WriteLine($"Sum of minus elements = {minissum}");

double max = array[0];int index = 0;

for (int i = 1; i < N; i++)
{
    if (max < array[i])
    {
        max = array[i];
        index = i;
    }
}

Console.WriteLine($"Max element = {max}; index = {index}");

double absmax = array[0];

absmax = Math.Abs(absmax);

for (int i = 0; i < N; i++)
{
    if (absmax < Math.Abs(array[i]))
    {
        absmax = Math.Abs(array[i]);
    }
}

Console.WriteLine($"Max mobule  value of array: {absmax}");

int indexSum = 0;

for (int i = 0; i < N; i++)
{
    if (array[i] > 0)
    {
        indexSum += 1;
    }
}

Console.WriteLine($"Positive index sum: {indexSum}");

int NumberIntegers = 0;

for (int i = 0; i < N; i++)
{
    if (array[i] % 1 == 0)
    {
        NumberIntegers += 1;
    }
}

Console.WriteLine($"Amount of integer values: {NumberIntegers}");