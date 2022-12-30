using System.Text;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть розмір масиву: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 100);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            int sum = 0;
            int max = array[0];
            int index = 0;
            int maxAbs = array[0];
            int sumIndex = 0;
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    sum += array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                    index = i;
                }
                if (Math.Abs(array[i]) > Math.Abs(maxAbs))
                {
                    maxAbs = array[i];
                }
                if (array[i] > 0)
                {
                    sumIndex += i;
                }
                if (array[i] % 1 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Сума від'ємних елементів масиву: " + sum);
            Console.WriteLine("Максимальний елемент масиву: " + max);
            Console.WriteLine("Номер (індекс) максимального елемента масиву: " + index);
            Console.WriteLine("Максимальний за модулем елемент масиву: " + maxAbs);
            Console.WriteLine("Сума індексів додатних елементів: " + sumIndex);
            Console.WriteLine("Кількість цілих чисел у масиві: " + count);
        }
    }
}