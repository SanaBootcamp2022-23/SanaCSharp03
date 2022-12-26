// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int N;
Console.Write("n = ");
N = int.Parse(Console.ReadLine());
int[] arr = new int[N];
double negativeSum = 0;
double max = arr[0];
double maxIndex = 0;
double maxModule = arr[0];
double positiveSum = 0;
double integer = 0;
for (int i = 0; i < N; i++)
{
    //сумa від’ємних елементів масиву;
    if (arr[i] < 0)
    {
        negativeSum += arr[i];
    }
    //максимальний елемент масиву;
    if (arr[i] > max)
    {
        max = arr[i];
        //номер (індекс) максимального елемента масиву;
        maxIndex = i;
    }
    //максимальний за модулем елемент масиву;
    if (Math.Abs(arr[i]) > Math.Abs(maxModule))
    {
        maxModule = arr[i];
    }
    //сумa індексів додатних елементів;
    if (arr[i] > 0)
    {
        positiveSum += arr[i];
    }
    if (arr[i] == arr[i])
    {
        integer++;
    }

}
Console.WriteLine($"negative elements sum = {negativeSum}");
Console.WriteLine($"maximum array = {max}");
Console.WriteLine($"maximum array index = {maxIndex}");
Console.WriteLine($"maximum module index = {maxModule}");
Console.WriteLine($"sum of positive elements = {positiveSum}");
Console.WriteLine($"amount of integers = {integer}");