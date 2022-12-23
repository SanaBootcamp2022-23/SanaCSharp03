Console.WriteLine("Amount of elements:");
int n = int.Parse(Console.ReadLine());
double[] arr = new double[n];
for(int i = 0; i< arr.Length;i++)
    arr[i] = double.Parse(Console.ReadLine());

double sum = 0, max, imax = 0; int count = 0;
foreach(double d in arr)
    if(d<0)
    sum += d;

Console.WriteLine($"Sum of negative numbers: {sum}");

max = arr[0];
for(int i = 1;i< arr.Length;i++)
    if (max < arr[i])
    {
        max = arr[i];
        imax = i;
    }

Console.WriteLine($"Max number: {max}");
Console.WriteLine($"Index of max number: {imax}");

max = Math.Abs(arr[0]);
for (int i = 1; i < arr.Length; i++)
    if (Math.Abs(max) < Math.Abs(arr[i]))
    max = arr[i];

Console.WriteLine($"Max by module number: {max}");
sum = 0;
for (int i = 0; i < arr.Length; i++)
    if (arr[i] > 0)
        sum += i;

Console.WriteLine($"Sum of indexes positive numbers: {sum}");
foreach(double d in arr)
{
    if (d == (int)d)
        count++;
}
Console.WriteLine($"Amount of integers: {count}");