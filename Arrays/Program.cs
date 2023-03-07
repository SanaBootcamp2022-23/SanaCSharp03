using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        int n;
        
        Console.WriteLine($"ВВедіть кількість елементів масиву");
        n = Convert.ToInt32(Console.ReadLine());

        double[] Array = new double[n];

        Console.WriteLine($"ВВедіть числа масиву");

        for (int i = 0; i < n; i++)
        {
            Array[i] = Convert.ToDouble(Console.ReadLine());
        }

        double sumNegativeNumbers = 0;
        double sumPositiveNumbers = 0;
        double maxNumberArray = 0;
        int indexMaxNumberArray = -1;
        double maxNumberModul = 0;
        int numberOfIntegers = 0;

        for (int i = 0; i < n; i++)
        {
            if (Array[i] < 0)
            {
                sumNegativeNumbers += Array[i];
            }

            if (Array[i] > 0)
            {
                sumPositiveNumbers += Array[i];
            }

            if (maxNumberArray < Array[i])
            {
                maxNumberArray = Array[i];
                indexMaxNumberArray = i;
            }

            if (Math.Abs(Array[i]) > maxNumberModul)
            {
                maxNumberModul = Array[i];
            }

            if (Array[i] == (int)Array[i])
            {
                numberOfIntegers++;
            }
        }

        Console.WriteLine("Сума від'ємних: " + sumNegativeNumbers);
        Console.WriteLine("Максимальний елемент: " + maxNumberArray);
        Console.WriteLine("Індекс максимального елемента: " + indexMaxNumberArray);
        Console.WriteLine("Максимальний за модулем елемент: " + maxNumberModul);
        Console.WriteLine("Сума індексів додатних елементів: " + sumPositiveNumbers);
        Console.WriteLine("Кількість цілих чисел: " + numberOfIntegers);
    }
}