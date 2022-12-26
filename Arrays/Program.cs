using System.Text;

namespace Arrayshttps://github.com/AndryVolynets/SanaCSharp05/blob/main/Arrays/Program.cs
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
                arr[i] = (i == random.Next(0, N) ? random.Next(-10, 10) : GetRandomNumber(-10, 10));
                Console.Write($"{Math.Round(arr[i], 3)}| ");
            }

            Console.WriteLine($"\n\n" +
                              $"Cума від’ємних елементів масиву = {Math.Round(arr.Where(x => x < 0).Sum(), 3)}\n" +
                              $"Максимальний елемент масиву = {Math.Round(arr.Max(), 3)}\n" +
                              $"Індекс максимального елемента масиву = {arr.ToList().IndexOf(arr.Max())}\n" +
                              $"Максимальний за модулем елемент масиву = {Math.Round(arr.Max(Math.Abs), 3)}\n" +
                              $"Cума індексів додатних елементів = {arr.Select((x, i) => x > 0 ? i : 0).Sum()}\n" +
                              $"Rількість цілих чисел у масиві = {arr.Count(x => x % 1 == 0)}");
        }
    }
}
