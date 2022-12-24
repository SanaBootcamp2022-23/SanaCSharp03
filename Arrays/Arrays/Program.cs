using System;

class Program
{
    public static void Main(string[] args)
    {
        int n;
        Console.WriteLine("Enter the value of the size of the array");
        Console.Write("-> ");
        n = int.Parse(Console.ReadLine());
        double[] arr = new double[n];

        for ( int i =0;i< n; i++)
        {
            Console.WriteLine($"Enter the value of {i+1} element");
            Console.Write("-> ");
            arr[i] = double.Parse(Console.ReadLine());
        }

        double max = arr[0], sum_neg=0, max_index=0, max_module = arr[0], sum_index=0, odd_count=0;
        for (int i=0; i<n; i++)
        {
            if (arr[i] > max) {
                max = arr[i];
                max_index = i;
            }
            if (arr[i] < 0)
                sum_neg += arr[i];
            else
                sum_index += i;
            if (Math.Abs(arr[i])>max_module)
                max_module = Math.Abs(arr[i]);
            if (arr[i] == (int)arr[i])
                odd_count++;
        }
        Console.WriteLine($"sum_neg -> {sum_neg}, max -> {max}, max_index -> {max_index}, max_module -> {max_module}, sum_index = {sum_index}, odd_count -> {odd_count}");
    }
}
