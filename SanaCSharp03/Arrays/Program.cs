using System.Text;

Console.OutputEncoding = Encoding.UTF8;

uint count = 0;
double negativeElementsSum = 0;
double maxElement = 0;
double maxElementIndex = 0;
double moduleMaxElement = 0;
double positiveElementsIndexSum = 0;
double integersCount = 0;


Console.Write("Введіть розмірність масиву (N): ");
count = uint.Parse(Console.ReadLine());

double[] arr = new double[count];


for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"Введіть значення arr[{i}]: ");
    arr[i] = double.Parse(Console.ReadLine());
}

maxElement = arr[0];

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] < 0)                                             //сума від'ємних елементів
        negativeElementsSum += arr[i];          

    if (arr[i] > 0)                                             //сума індексів додатніх елементів 
        positiveElementsIndexSum += i;

    if (arr[i] == (int)arr[i])                                  //кількість цілих чисел
        integersCount++;

    if (arr[i] > maxElement)                                    //максимальний елемент + його індекс
    {
        maxElement = arr[i];
        maxElementIndex = i;
    }
        
}

moduleMaxElement = (arr[0] < 0) ? arr[0] * -1 : arr[0];

for (int i = 1; i < arr.Length; i++)                            //максимальний за модулем елемент
{
   double tmp = (arr[i] < 0) ? arr[i] * -1 : arr[i];

    if (tmp > moduleMaxElement) 
        moduleMaxElement = tmp;
}


Console.WriteLine($"\nСума від'ємних елементів масиву: {negativeElementsSum}");
Console.WriteLine($"Максимальний елемент масиву: {maxElement}");
Console.WriteLine($"Індекс максимального елемента масиву: {maxElementIndex}");
Console.WriteLine($"Максимальний за модулем елемент масиву: {moduleMaxElement}");
Console.WriteLine($"Сума індексів додатних елементів: {positiveElementsIndexSum}");
Console.WriteLine($"Кількість цілих чисел в масиві: {integersCount}");


