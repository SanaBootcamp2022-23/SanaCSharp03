using System.Runtime.InteropServices;
using System.Text;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введіть кількість елементів масиву");
            int count = int.Parse(Console.ReadLine()), i = 0, j = 0, negSum = 0, max = 0, maxi = 0, maxabs = 0, indexSum = 0, intCount = 0, intDefine;
            int[] arr = new int[count];
            Console.WriteLine("\nВведіть елементи масиву");
            for (i = 0; i < count; i++) {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] < 0) negSum += arr[i];
                if (max < arr[i]) {
                    max = arr[i];
                    maxi = i;
                }
                if (maxabs < Math.Abs(arr[i])) maxabs = Math.Abs(arr[i]);
                if (arr[i] > 0) indexSum += i + 1;
                if ((arr[i] - ((arr[i] / 10) * 10)) >= 1) intCount++;
                if ((arr[i] - ((arr[i] / 10) * 10)) <= -1) intCount++;
            }
            Console.WriteLine($"\n1. Сума від'ємних елементів масиву: {negSum}");
            Console.WriteLine($"\n2 - 3. Максимальний елемент масиву: {max}, його індекс: {maxi + 1}");
            Console.WriteLine($"\n4. Максимальний за модулем елемент масиву: {maxabs}");
            Console.WriteLine($"\n5. Cума індексів додатніх елментів: {indexSum}");
            Console.WriteLine($"\n6. Cума індексів додатніх елментів: {intCount}");
        }
    }
}