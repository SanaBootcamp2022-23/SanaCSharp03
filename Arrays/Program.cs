int length, maxIndex = 0, sumIndex = 0, intNumbers = 0;
double sumNegative = 0, maxElemnt = 0, maxAbs = 0;

Console.Write("Будь ласка, введiть довжину масиву: ");
length = int.Parse(Console.ReadLine());

double[] array = new double[length];

for (int i = 0; i < length; i++)
{
    Console.Write($"Елемент [{i}] = ");
    array[i] = double.Parse(Console.ReadLine());

    if (array[i] < 0)
    {
        sumNegative += array[i];
    }

    if (array[i] > maxElemnt)
    {
        maxElemnt = array[i];
        maxIndex = i;
    }

    if (Math.Abs(array[i]) > maxAbs)
    {
        maxAbs = Math.Abs(array[i]);
    }

    if (array[i] > 0)
    {
        sumIndex += i;
    }

    if (array[i] % 1 == 0)
    {
        intNumbers++;
    }
}

Console.WriteLine($"Cума вiд’ємних елементiв масиву: {sumNegative}");
Console.WriteLine($"Максимальний елемент масиву: {maxElemnt}");
Console.WriteLine($"Номер (iндекс) максимального елемента масиву: {maxIndex}");
Console.WriteLine($"Максимальний за модулем елемент масиву: {maxAbs}");
Console.WriteLine($"Сумa iндексiв додатних елементiв: {sumIndex}");
Console.WriteLine($"Кiлькiсть цiлих чисел у масивi: {intNumbers}");

Console.ReadLine(); //щоб консоль не закривалася відразу