const int n = 10;
double[] arr = new double[n] { 3.6, 7, 8, 45, 6.5, -9.4, -8, 0, 74, -100 };
double sum = 0, max, imax = 0;
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
    if (max < Math.Abs(arr[i]))
    max = arr[i];

Console.WriteLine($"Max by module number: {max}");
sum = 0;
for (int i = 0; i < arr.Length; i++)
    if (arr[i] > 0)
        sum += i;

Console.WriteLine($"Sum of indexes positive numbers: {sum}");