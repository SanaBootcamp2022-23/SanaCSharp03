Console.OutputEncoding = System.Text.Encoding.UTF8;
int Length;
do
    Console.WriteLine("Введіть розмір масиву(>0) - ");
while (!(int.TryParse(Console.ReadLine(), out Length) && Length > 0));
double[] mas = new double[Length];
Random rnd = new Random();
double sumNegativ = 0, max = double.MinValue, maxModule = double.MinValue;
int indexMax=0, sumPostiveIndex = 0, numberInteger = 0;
for (int i = 0; i < Length; i++)
{
    mas[i] = (rnd.Next(-1000, 1000)) / 10.0;
    Console.WriteLine(mas[i]);
    if (mas[i] < 0)//суму від’ємних елементів масиву;
        sumNegativ += mas[i];
    else
        sumPostiveIndex += i;
    if (mas[i] > max)//максимальний елемент масиву;номер (індекс) максимального елемента масиву;
    {
        max = mas[i];
        indexMax = i;
    }
    if (Math.Abs(mas[i]) > maxModule)//максимальний за модулем елемент масиву;
        maxModule = mas[i];
   // if (mas[i] > 0) //суму індексів додатних елементів;
        
    if (mas[i] == Convert.ToInt32(mas[i]))//кількість цілих чисел у масиві.
        numberInteger++;
}
Console.WriteLine($"Cума від’ємних елементів масиву = {sumNegativ}");
Console.WriteLine($"Максимальний елемент масиву = {max}");
Console.WriteLine($"Номер (індекс) максимального елемента масиву = {indexMax}");
Console.WriteLine($"Максимальний за модулем елемент масиву = {maxModule}");
Console.WriteLine($"Сума індексів додатних елементіву = {sumPostiveIndex}");
Console.WriteLine($"Кількість цілих чисел у масиві = {numberInteger}");