
Random rnd = new Random();
Random rndStep = new Random();

Console.WriteLine("Введiть розмiр масиву");

int n = int.Parse(Console.ReadLine());
double sumNegative = 0;

double [] arr = new double[n];

Console.WriteLine("---------------------");
Console.WriteLine("Дано масив:");
Console.WriteLine("---------------------");
for (int i = 0; i < arr.Length; i++)
{
    if(i%rndStep.Next(1, 4) == 0)
    {
        arr[i] = Math.Round(rnd.Next(-20, 20) + rnd.NextDouble(), 2);
    }
    else
    {
        arr[i] = rnd.Next(-50, 20) + 1;
    }
    
    Console.Write(arr[i] + " ");
}

for(int i = 0; i < arr.Length; i++)
{
    if (arr[i] < 0)
    {
        sumNegative += arr[i];
    }
}
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("Сума вiд'ємних елементiв масиву = " + sumNegative);
Console.WriteLine("---------------------");

double maxElem = arr.Max();
Console.WriteLine("Максимальний елемент масиву: " + maxElem);
Console.WriteLine("---------------------");

int indexMax = arr.ToList().IndexOf(maxElem);
Console.WriteLine("Iндекс максимального елементу масиву: " + indexMax);
Console.WriteLine("Порядковий номер максимального елементу масиву: " + (indexMax + 1));
Console.WriteLine("---------------------");

double maxModElem = Math.Abs(arr[0]);

for (int i = 1; i < arr.Length; i++)
{
    if (Math.Abs(arr[i]) > maxModElem)
    {
        maxModElem = Math.Abs(arr[i]);
    }
}

Console.WriteLine("Максимальний за модулем елемент масиву: " + maxModElem);
Console.WriteLine("---------------------");

double sumIndexes = 0;

for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        sumIndexes += i;
    }
}

Console.WriteLine("Сума iндексiв додатнiх елементв = " + sumIndexes);
Console.WriteLine("---------------------");

int quantIntElems = 0;

for (int i = 1; i < arr.Length; i++)
{
    if (arr[i]%1 == 0)
    {
        quantIntElems++;
    }
}

Console.WriteLine("Кiлькiсть цiлих чисел у масивi = " + quantIntElems);
Console.WriteLine("---------------------");