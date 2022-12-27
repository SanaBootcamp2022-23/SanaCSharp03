using System.Linq;
namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            int n;
            Console.Write("Введіть розмір масиву:");n = int.Parse(Console.ReadLine());
            double[] array = new double[n];
            var rand = new Random();
            Console.WriteLine("Згеренований масив довжиною {0}", n);
            int sumOfPositiveIndexElement = 0;
            double sumOfNegativeElementsOfArray = 0;
            int numberOfIntElementOfArray=0;
            for(int i = 0; i < n; i++) 
            {
                if ((i + 1) % 3 == 0) { array[i] = rand.NextInt64(-10, 5); } 
                else { array[i] = rand.NextDouble() + rand.NextInt64(-10, 5); }
                Console.Write("{0} ",array[i]);
                if (array[i] > 0) sumOfPositiveIndexElement+=i;
                else { sumOfNegativeElementsOfArray += array[i]; }
                if (array[i] - Math.Round(array[i]) == 0) { numberOfIntElementOfArray++; }
            }
            Console.WriteLine();
            Console.WriteLine("Сума від'ємних елементів масиву  = {0}", sumOfNegativeElementsOfArray);
            double min = Enumerable.Min(array);
            double max = Enumerable.Max(array);
            Console.WriteLine("Максимальний елемент масиву  = {0}", max);

            for (int i =0; i < n; i ++)
            {
                if (array[i] == max) { Console.WriteLine("Індекс максимального елементу масива = {0}", i);break; }
            
            }
            Console.WriteLine("Максимальний елемент масиву за модулем  = {0}", Math.Abs(max) > Math.Abs(min)?max:min);
            Console.WriteLine("Сумма індексів додатних елементів = {0}", sumOfPositiveIndexElement);
            Console.WriteLine("Кількість цілих чисел у масиві = {0}", numberOfIntElementOfArray);
        }
    }
}