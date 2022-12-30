using System.Text;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;
float summaneg = 0;
float max;
int maxi = 0;
float maxfabs;
int summaindex, countint = 0;
Console.Write("Введіть розмір масиву: ");
int arrSize = int.Parse(Console.ReadLine());
float[] array; array = new float[arrSize];
max = 0;
maxfabs = 0;
summaindex = 0;
int[] array2; array2 = new int[arrSize];
Console.WriteLine("Вводьте елементи масиву(через Enter): ");
for (int i = 0; i < arrSize; i++)
{
    array[i] = float.Parse(Console.ReadLine());
    if (array[i] < 0) summaneg += array[i];
    if (array[i] > max) { max = array[i]; maxi = i; }
    if (Math.Abs(array[i]) > maxfabs) maxfabs = array[i];
    if (array[i] > 0) summaindex += i;
    array2[i] = (int)array[i];
    if (array[i] - array2[i] == 0) countint++;
}
Console.WriteLine($"Сумма від'ємних елементів: {summaneg}");
Console.WriteLine($"Максимальний елемент масиву: Array[{maxi}]: {max}");
Console.WriteLine($"Максимальний за модулем елемент масиву: {maxfabs}");
Console.WriteLine($"Сума індексів додатніх елементів: {summaindex}");
Console.WriteLine($"Кількість цілих елементів: {countint}");
