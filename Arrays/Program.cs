class Program
{
    static void Main(string[] agrs)

    {
        int count;

        Console.Write("Write N(count): ");

        count = int.Parse(Console.ReadLine());
        if (count<=0)
        {
            Console.WriteLine("Error (write positive count)");
        }

        double[] array = new double[count];
        double sum = 0;

        for (int i = 0; i < count; i++)
        {
            Console.Write("Write array element: ");

            array[i] = double.Parse(Console.ReadLine());

            if (array[i] < 0)
                sum = sum + array[i];
        }

        double maxElement = array.Max();
        double index = -1;

        for (int i = 0; i < count; i++)
        {
           if (maxElement <= array[i])
            {
                maxElement = array[i];
                index = i;
            }
        }

        double minElement = array.Min();
        double maxModule = maxElement;
        for (int i = 0; i < count; i++)
        {
            if (minElement < 0)
            {
                maxModule = minElement * (-1);
            }
            if(maxModule<maxElement)
            {
                maxModule = maxElement;
            }
                    
        }

        int sumIndex = 0;

        for (int i = 0; i < count; i++)
        {
            if (array[i] > 0)
            {
                sumIndex = sumIndex + i;
            }
        }

        double sumInteger = 0;
        for (int i = 0; i < count; i++)
        {
            if (array[i] % 1 == 0)
            {
                sumInteger = sumInteger + array[i];
            }

        }







             Console.WriteLine("Sum of negative elements: " + sum);
             Console.WriteLine("Max element: " + maxElement);
             Console.WriteLine("Index of max element: " + index);
             Console.WriteLine("Module max element: " + maxModule);
             Console.WriteLine("Index sum of positive elements: " + sumIndex);
             Console.WriteLine("Sum of integers: " + sumInteger);

    }
}