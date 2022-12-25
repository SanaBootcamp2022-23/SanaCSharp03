class Program
{
   static void Main()
    {
        Console.Write("Enter length of array:");
        int n = int.Parse(Console.ReadLine());
        double[] array = new double[n];
        Console.WriteLine($"Enter {n} numbers:");
        for (int i = 0; i < n; i++)
        {
            array[i] = double.Parse(Console.ReadLine());
        }
        Console.WriteLine("\n");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"{array[i]}  ");
        }
        Console.WriteLine("\n");
        Console.WriteLine($"\nSum of negatin numbers = {negativeSum(array, n)}");
        Console.WriteLine($"\nMax number = {maxNumber(array, n)}");
        Console.WriteLine($"\nIndex of max number = {maxNumberIndex(array, n)}");
        Console.WriteLine($"\nMax absolutely number = {maxNumberAbsolute(array, n)}");
        Console.WriteLine($"\nIndex sum of positive numbers = {positiveIndexSum(array, n)}");
        Console.WriteLine($"\nCount of integer numbers = {integerCount(array, n)}");
    }
    static double negativeSum(double[] array, int n)
    {
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            if (array[i] < 0)
            {
                sum += array[i];
            }
        }
        return sum;
    }
    static double maxNumber(double[] array, int n)
    {
        double max = array[0];
        for (int i = 0; i < n; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }
    static int maxNumberIndex(double[] array, int n)
    {
        double max = array[0];
        int index = 0;
        for (int i = 0; i < n; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                index = i;
            }
        }
        return index;
    }
    static double maxNumberAbsolute(double[] array, int n)
    {
        double max = array[0];
        for (int i = 0; i < n; i++)
        {
            if (Math.Abs(array[i]) > Math.Abs(max))
            {
                max = array[i];
            }
        }
        return max;
    }
    static int positiveIndexSum(double[] array, int n)
    {
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            if (array[i] > 0)
            {
                sum += i;
            }
        }
        return sum;
    }
    static int integerCount(double[] array, int n)
    {
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            if (array[i] == Convert.ToInt32(array[i]))
            {
                count++;
            }
        }
        return count;
    }
}