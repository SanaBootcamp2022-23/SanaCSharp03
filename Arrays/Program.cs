using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

Console.WriteLine("Введіть кількість елементів масиву: ");
int n = Convert.ToInt32(Console.ReadLine());
int sumNegativeElement = 0,
    maxElement = 0,
    indexMaxElement = 0,
    intNum = 0,
    sumIndexPositive = 0;

Random rand = new Random();

int[] arr = new int[n];
Console.WriteLine("Створений масив:");
for (int i = 0; i < n; i++)
{
    arr[i] = rand.Next(-10,10);
    Console.Write($"{arr[i]} ");
}

int maxElementModul = arr[0];
for(int i = 0; i < n; i++)
{
    if (arr[i] < 0)
        sumNegativeElement += arr[i];
    if (arr[i] == arr.Max())
        maxElement = arr[i];
    if (arr[i] == arr.Max())
        indexMaxElement = i;
    if (Math.Abs(arr[i]) > Math.Abs(maxElementModul))
        maxElementModul = arr[i] ;
    if (arr[i] > 0)
        sumIndexPositive += i;
    if (arr[i] % 1 == 0)
        intNum++;
}

Console.WriteLine($"\nСума від’ємних елементів масиву: {sumNegativeElement}\n" +
                  $"Максимальний елемент масиву: {maxElement}\n" +
                  $"Номер (індекс) максимального елемента масиву: {indexMaxElement}\n" +
                  $"Mаксимальний за модулем елемент масиву: {maxElementModul}\n" +
                  $"Сума індексів додатних елементів: {sumIndexPositive}\n" +
                  $"Кількість цілих чисел у масиві: {intNum}");