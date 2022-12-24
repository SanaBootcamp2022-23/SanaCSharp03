
uint count;
Console.Write("Введите количество элементов массива = ");
count = uint.Parse(Console.ReadLine());
double[]array = new double[count];
double summa_negative = 0;
uint summa_pozitiv_index = 0;
double max = 0;
double max_absolute = 0;
uint index = 0;
uint number_integers =0;

for (uint i = 0; i < count; i++)
{
    Console.Write($"Введите текущие значения массива {i}-  ");
    array[i] = double.Parse(Console.ReadLine());
    //определяем сумму отрицательных значений
    if (array[i] < 0)
        summa_negative += array[i];
    //определяем сумму индексов положительных значений
    if (array[i] > 0)
        summa_pozitiv_index += i;
    //определяем элемент массива с максимальным значением и его индекс 
    if (max <= array[i])
    {
        max = array[i];
        index = i;
    }
    //определяем абсолютное максимальное значение элемента массива 
    if (Math.Abs(array[i]) > Math.Abs(max_absolute))
        max_absolute = array[i];
    //определяем количество целых чисел в массиве
    if (array[i] == Math.Round(array[i], 0))
    number_integers += 1;
}
Console.WriteLine($"Сумма отрицательных значений = {summa_negative}");
Console.WriteLine($"Сумма индексов положительных значений = {summa_pozitiv_index}");
Console.WriteLine($"Максимальное значение элемента = {max}");
Console.WriteLine($"Индекс максимального элемента = {index}");
Console.WriteLine($"Абсолютное максимальное значение элемента = {max_absolute}");
Console.WriteLine($"Количество целых чисел в массиве  = {number_integers}");
