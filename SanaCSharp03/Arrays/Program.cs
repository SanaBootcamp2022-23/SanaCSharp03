using System.Text;

Console.OutputEncoding = UTF8Encoding.UTF8;

Console.Write("n = ");
int num_int = 0, max_el_pos = 0, sum_positive_index = 0, count = int.Parse(Console.ReadLine());
double[] arr = new double[count];
double sum_negative = 0, max_el = 0, max_el_abs = 0;

for (int i = 0; i < count; i++)
{
    Console.Write($"arr[{i}] = ");
    arr[i] = double.Parse(Console.ReadLine());
    #region сума від'ємних елементів
    if (arr[i] < 0)
    {
        sum_negative += arr[i];
    }
    #endregion
    #region пошук індекса максимального елемента і максимального елемента за модулем
    if (i == 0)
    {
        max_el = arr[0];
        max_el_abs = arr[0];
    }
    else
    {
        if (arr[i] > max_el)
        {
            max_el = arr[i];
            max_el_pos = i;
        }

        if (Math.Abs(arr[i]) > Math.Abs(max_el_abs)) max_el_abs = arr[i];
    }
    #endregion
    #region сума індексів додатніх елементів
    if (arr[i] > 0) sum_positive_index += i;
    #endregion
    #region кількість цілих чисел
    if (arr[i] % 1 == 0) num_int++;
    #endregion
}
Console.WriteLine($"Cума від’ємних елементів масиву = {sum_negative}\n" +
    $"Максимальний елемент масиву = {max_el}\n" +
    $"Номер (індекс) максимального елемента = {max_el_pos}\n" +
    $"Максимальний за модулем елемент масиву = {max_el_abs}\n" +
    $"Сума індексів додатних елементів = {sum_positive_index}\n" +
    $"Кількість цілих чисел у масиві = {num_int}");