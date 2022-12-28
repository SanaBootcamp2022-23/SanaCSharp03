using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;
Console.Write("Введіть кількість чисел = ");
int n = int.Parse(Console.ReadLine());
float [] mas  = new float [n];
float sumNegativeNumbers=0, maxElement = mas[0], indexMaxElement=0, absMaxElement = mas[0], sumIndexPositiveElements=0, numberIntElements=0;
for (int i = 0; i < mas.Length; i++)
{
    Console.Write($"{i} - елемент = ");
    mas[i] = float.Parse(Console.ReadLine());
    if (mas[i] < 0) sumNegativeNumbers += mas[i];
    if (mas[i] > maxElement)
    {
        maxElement = mas[i];
        indexMaxElement = i;
    }
    if (Math.Abs(mas[i]) > Math.Abs(absMaxElement)) absMaxElement = mas[i];
    if (mas[i]>0) sumIndexPositiveElements += i;
    if (mas[i]%1==0) numberIntElements++;
}
Console.WriteLine($"Сума від'ємних елементів масиву = {sumNegativeNumbers}\n" + $"Максимальий елемент масиву = {maxElement}\n" + $"Номер максимального елементу масиву = {indexMaxElement}\n" + $"Максимальний за модулем елемент масиву = {absMaxElement}\n" + $"Сума індексів додатних елементів = {sumIndexPositiveElements}\n" + $"Кількість цілих чисел = {numberIntElements}");