namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -1, 2, 3, 4, 10, -6, -20 };
            int negativeValues = 0;
            int maxValue = 0;
            int maxValueIndex = 0;
            int maxValueByModule = 0;
            int sumValues = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    negativeValues += arr[i];
                }
                else
                {
                    sumValues += arr[i];
                }
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                    maxValueIndex = i;
                }
                if (Math.Abs(arr[i]) > maxValueByModule)
                {
                    maxValueByModule = arr[i];
                }
            }
            Console.WriteLine($"Сума негативних чисел :{negativeValues}");
            Console.WriteLine($"Максимальне число :{maxValue}");
            Console.WriteLine($"Iндекс максимального числа :{maxValueIndex}");
            Console.WriteLine($"Максимальне число по модулю :{maxValueByModule}");
            Console.WriteLine($"Сума додатніх чисел: {sumValues}");
        }
    }
}