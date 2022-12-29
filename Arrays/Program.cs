internal class Program
{
    private static void Main()
    {
        NewLine();

        int numsLen = ParseIntVar("array length");
        double[] nums = new double[numsLen];
        FillArray(nums, -10, 10);

        NewLine();
        Console.WriteLine("Generated array: ");
        PrintArray(nums);

        int maxIdx, absMaxIdx, integerCounter, positiveIdxsSum;
        double negativeSum, maxEl, absMaxEl;

        maxIdx = absMaxIdx = integerCounter = 0;
        negativeSum = positiveIdxsSum = 0;
        maxEl = absMaxEl = nums[0];

        for (int i = 0; i < nums.Length; i++)
        {
            double num = nums[i], numAbs = Math.Abs(num);

            if (isNegative(num))
            {
                negativeSum += num;
            }

            if (num > maxEl)
            {
                maxEl = num;
                maxIdx = i;
            }

            if (numAbs > Math.Abs(absMaxEl))
            {
                absMaxEl = num;
                absMaxIdx = i;
            }

            if (isPositive(num))
            {
                positiveIdxsSum += i;
            }

            if (isInteger(num))
            {
                integerCounter++;
            }
        }

        NewLine(2);

        Console.WriteLine("Task results: ");
        PrintAsListItem($"Sum of negative elements: {negativeSum}");
        PrintAsListItem($"Max element: {maxEl}, (i = {maxIdx})");
        PrintAsListItem($"ABS max element: {absMaxEl}, (i = {absMaxIdx})");
        PrintAsListItem($"Sum of positive elements indexe's: {positiveIdxsSum}");
        PrintAsListItem($"Number of integers: {integerCounter}");
    }

    private static bool isPositive(double num) => num > 0;
    private static bool isNegative(double num) => num < 0;
    private static bool isInteger(double num)
    => Math.Abs(num % 1) <= (Double.Epsilon * 100);
    // private static bool isInteger(double num) => num % 1 == 0;

    public static void FillArray(
        double[] arr,
        double minimum,
        double maximum)
    {
        Random rand = new Random();

        for (int i = 0; i < arr.Length; i++)
        {
            double num = minimum + rand.NextDouble() * (maximum - minimum);

            // Generate integer or double
            int digits = rand.Next(1, 2);
            num = System.Math.Round(num, digits);

            arr[i] = num;
        }
    }

    private static void PrintArray(double[] arr)
    {
        Console.Write("[");

        int len = arr.Length;
        for (int i = 0; i < len; i++)
        {
            bool isLast = i == len - 1;
            var el = arr[i];

            Console.Write($"{el}{(isLast ? "" : ", ")}");
        }

        Console.Write("]");
    }

    private static void NewLine(int amount = 1)
    => Enumerable.Range(0, amount)
        .ToList()
        .ForEach(i => Console.WriteLine());

    private static void PrintAsListItem(string value)
    => Console.WriteLine($"\t - {value}");

    private static double ParseDoubleVar(string varName)
    {
        bool success;
        double result;

        do
        {
            Console.Write($"Insert value for {varName}: ");
            success = double.TryParse(Console.ReadLine(), out result);

            if (!success)
                Console.WriteLine("\nParsing error, try again");
        } while (!success);

        return result;
    }

    private static int ParseIntVar(string varName) => (int)ParseDoubleVar(varName);
}
