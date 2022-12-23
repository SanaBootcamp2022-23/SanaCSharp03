using System.Text;

namespace Arrays
{
    internal class Program
    {
        private static readonly Random random = new Random();
        public static double GetRandomNumber(double minimum, double maximum)
        {
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int N = 10;
            double[] arr = new double[N];

            for (int i = 0; i < N; i++)
            {
                arr[i] = GetRandomNumber(-10, 10);
                Console.Write($"{Math.Round(arr[i], 2)} ");
            }

            Console.WriteLine($"\n\n" +
                              $"Cума від’ємних елементів масиву = {Math.Round(arr.Where(x => x < 0).Sum(), 2)}\n" +
                              $"Максимальний елемент масиву = {Math.Round(arr.Max())}\n" +
                              $"Індекс максимального елемента масиву = {arr.ToList().IndexOf(arr.Max())}\n" +
                              $"Максимальний за модулем елемент масиву = {arr.Max(Math.Abs)}\n" +
                              $"Cума індексів додатних елементів = {arr.Select((x, i) => x >= 0 ? i : 0).Sum()}\n" +
                              $"Rількість цілих чисел у масиві = {arr.Count(x => x % 1 == 0)}");
        }
    }
}