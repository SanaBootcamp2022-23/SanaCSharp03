namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter number of values:");
            int n = Convert.ToInt32(Console.ReadLine());
            
            double []arr= new double[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToDouble(Console.ReadLine());
            }

            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    sum += arr[i];
                }
            }

            Console.WriteLine("Sum of minus elements:" + sum.ToString());

            double max = arr[0];
            int index = 0;
            for (int i = 1; i < n; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                    index = i;
                }
            }

            Console.WriteLine($"Max element: {max}; index: {index}");

            double absMax = arr[0];

            absMax= Math.Abs(absMax);

            for (int i = 0; i < n; i++)
            {
                if (absMax < Math.Abs(arr[i]))
                {
                    absMax = Math.Abs(arr[i]);
                }
            }

            Console.WriteLine($"Max mobule  value of array: {absMax}");

            int indexSum = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                {
                    indexSum += 1;
                }
            }

            Console.WriteLine($"Positive index sum: {indexSum}");

            int amountOfIntegerValues = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 1 == 0)
                {
                    amountOfIntegerValues+= 1;  
                }
            }

            Console.WriteLine($"Amount of integer values: {amountOfIntegerValues}");
        }
    }
}