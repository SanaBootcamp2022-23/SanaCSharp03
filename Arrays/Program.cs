using System.Globalization;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;
CultureInfo customCulture = (CultureInfo)
System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

int count,countIntegers=0,indexMax=0;
double max=0,maxAbs=0,sumNegative = 0,sumIndexPositive = 0;
Console.WriteLine("Кількість елементів масиву введіть");
count = int.Parse(Console.ReadLine());
double[] arrayNumber = new double[count];
for (int i = 0; i < count; i++)
{
    Console.Write($"Введіть {i} елемент : ",i);
    arrayNumber[i] = double.Parse(Console.ReadLine());
}
max=arrayNumber[0];
maxAbs=arrayNumber[0];
for(int i = 0; i < count; i++)
{
    if(arrayNumber[i] < 0)
    {
        sumNegative+=arrayNumber[i];
    }
    if(arrayNumber[i] > max)
    {
        max=arrayNumber[i];
        indexMax = i;
    }
    if (maxAbs < Math.Abs(arrayNumber[i]))
    {
        maxAbs=arrayNumber[i];
    }
    if (arrayNumber[i]>0)
    {
        sumIndexPositive += i;
    }
    if (arrayNumber[i]%1==0)
    {
        countIntegers++;
    }

}
Console.WriteLine($"Сума негативних чисел: {sumNegative}" +
    $"\nМаксимальне число масиву : {max}" +
    $"\nІндекс максималного числа масиву: {indexMax}" +
    $"\nМаксимальне число за модулем: {maxAbs}" +
    $"\nCума індексів додатних елементів масиву {sumIndexPositive}" +
    $"\nКількість цілих чисел {countIntegers}",sumNegative,max,indexMax,maxAbs,sumIndexPositive,countIntegers);

