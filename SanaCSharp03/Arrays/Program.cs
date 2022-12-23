using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;


System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
        System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

int count, indexMaxElement = 0, modMaxElement = 0, indexSumPosEl = 0, amountWholeNumber = 0;
double summNegative = 0, elMax = 0, modMax = 0;
Console.WriteLine("Введіть кількість елементів масиву");
count = int.Parse(Console.ReadLine());
if (count <= 0)
{
    Console.WriteLine("Помилка ! Масив не може дорівнювати нулю або від'ємному значенню");
    return;
}
double[] arr = new double[count];
Console.WriteLine("Введіть числа для заповнення масиву");

for (int i = 0; i < count; i++)
{
    Console.Write($"Число {i+1} = ");
    arr[i] = double.Parse(Console.ReadLine());

    // Сума від'ємних елементів масиву

    if (arr[i] < 0)
        summNegative += arr[i];

    // Максимальний елемент масиву та індекс максимального елементу

    if (elMax < arr[i])
    {
        elMax = arr[i];
        indexMaxElement = i;
    }

    //Максимальний за модулем елемент масиву

    if (Math.Abs(arr[i]) >= modMax)
    {
        modMax = Math.Abs(arr[i]);
        modMaxElement = i;
    }

    // Сума індексів додатніх елементів
    if (arr[i] > 0)
        indexSumPosEl += i;

    // Кількість цілих чисел

    if (arr[i] % 1 == 0)
        amountWholeNumber++;
}
Console.WriteLine
    ($"Сума від'ємних елементів масиву = {summNegative}\n" +
    $"Максимальний елемент масиву = {elMax}\n" +
    $"Індекс максимального елементу = {indexMaxElement}\n" +
    $"Максимальний за модулем елемент масиву = {modMax}\n" +
    $"Сума індексів додатних елементів = {indexSumPosEl}\n" +
    $"Кількість цілих чисел = {amountWholeNumber}");