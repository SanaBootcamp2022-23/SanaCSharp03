

Console.WriteLine("Enter N: ");
try
{
    int n = int.Parse(Console.ReadLine());
    int[] arr = new int[n];
    Console.Write("\nArray: ");
    for (int i = 0; i < arr.Length; i++)
    {
        Random rnd = new Random();
        arr[i] = rnd.Next(-n, n);
        Console.Write($" {arr[i]}");
    }

    int negSum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
        {
            negSum += arr[i];
        }
    }

    int max = arr.Max();

    int[] arrAbs = new int[n];
    for (int i = 0; i < arrAbs.Length; i++)
    {
        arrAbs[i] = Math.Abs(arr[i]);
    }
    int maxAbs = arrAbs.Max();

    int indexSum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            indexSum += i;
        }
    }
    Console.WriteLine($"\nSum negative: {negSum}");
    Console.WriteLine($"Max: {max}");
    Console.WriteLine($"Index of max: {Array.IndexOf(arr, max)}");
    Console.WriteLine($"Max abs: {maxAbs}");
    Console.WriteLine($"Sum of indexes: {indexSum}");
}
catch (FormatException e)
{
    Console.WriteLine(e.ToString());
}
