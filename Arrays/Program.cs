int N;
Console.WriteLine("Введiть розмiр масиву");
N= int.Parse(Console.ReadLine());
double[] mass = new double [N];
Console.WriteLine("Якi числа?:");
for (int i = 0; i < N; i++)
{
    Console.Write($"[{i + 1}]=");
    mass[i]= int.Parse(Console.ReadLine());
}
int    summIndexPositive=0, countWholeNumb=0;
double minus=0, maxEl = mass[0], maxModuleEl = Math.Abs(mass[0]), indexMaxEl=0;
for (int i = 0; i < N; i++)
{
    if (mass[i] < 0)
    {
        minus += mass[i];
    }
    if (maxEl < mass[i])
    {
        maxEl = mass[i];
        indexMaxEl = i;
    }
    if (maxEl < Math.Abs(mass[i]))
    {
        maxModuleEl = mass[i];
     
    }
    if (mass[i] > 0)
    {
        summIndexPositive += i;
    }
    if (Math.Abs(mass[i]) % 1 == 0)
    {
        countWholeNumb++;
    }
}
Console.WriteLine(
    $"Сума вiд'ємних елементiв: {minus}\n" +
    $"Mаксимальний елемент масиву: {maxEl}\n" +
    $"Iндекс максимального елемента масиву: {indexMaxEl}\n" +
    $"Mаксимальний за модулем елемент масиву: {maxModuleEl}\n" +
    $"Cуму iндексiв додатних елементiв: {summIndexPositive}\n"+
    $"Kiлькiсть цiлих чисел у масив: {countWholeNumb}\n"
    );
