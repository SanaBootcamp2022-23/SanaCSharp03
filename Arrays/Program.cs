using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;
Console.WriteLine("Введіть N(кількість елементів згенерованого масиву): ");
int n = Convert.ToInt32(Console.ReadLine());
int negativesum = 0,
    positiveindexsum = 0,
    maxElement,
    indexOfMaxElement = 0,
    countOfIntegerNum = 0;


Random rand = new Random();

int[] arr = new int[n];
Console.WriteLine("Згенерований масив: ");
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(-10, 10);
    Console.WriteLine(arr[i]);
}
maxElement = arr.Max();
int maxAbsElement = arr[0];

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] < 0)
    {
        negativesum += arr[i];
    }
    if (arr[i] > 0)
    {
        positiveindexsum += i;
    }
    if (arr[i] == maxElement)
    {
        indexOfMaxElement = i;
    }
    if (arr[i] % 1 == 0)
    {
        countOfIntegerNum++;
    }

    if (Math.Abs(arr[i]) > Math.Abs(maxAbsElement))
    {
        maxAbsElement = arr[i];
    }

}
Console.WriteLine($"Cумa від’ємних елементів масиву:{negativesum}\nMаксимальний елемент масиву:{maxElement}\nHомер (індекс) максимального елемента масиву:{indexOfMaxElement}\nMаксимальний за модулем елемент масиву:{maxAbsElement}\nCумa індексів додатних елементів:{positiveindexsum}\nKількість цілих чисел у масиві:{countOfIntegerNum}");