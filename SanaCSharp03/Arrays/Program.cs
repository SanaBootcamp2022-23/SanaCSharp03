using System.Text;
using System.Threading.Tasks.Dataflow;
using static System.Console;
using static System.Math;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

int N;

Write("Введіть кількість елементів масиву:");
N = int.Parse(ReadLine());

double[] mas = new double[N];

WriteLine("\nВведіть елементи масиву:");

for (int i = 0; i < N; i++)
{
    mas[i] = double.Parse(ReadLine());
}

WriteLine("\nМасив:");

for (int i = 0; i < N; i++)
{
    Write("| {0} |", mas[i]);
}

double sumneg = 0, max = mas[0], maxmod = mas[0];
int maxi = 0, sumi = 0, countZ = 0;

for (int i = 0; i < mas.Length; i++)
{
    if(mas[i] < 0) 
    {
        sumneg += mas[i];
    }
    
    if (mas[i] > max)
    {
        max = mas[i];
        maxi = i;
    }

    if (Abs(mas[i]) > Abs(maxmod))
    {
        maxmod = mas[i];
    }

    if (mas[i] > 0)
    {
        sumi += i;
    }

    if (mas[i] % 1 == 0)
    {
        countZ++;
    }
}

WriteLine("\n\nСума від'ємних елементів масиву: {0}", sumneg);
WriteLine("\n\nМаксимальний елемент масиву: {0}\nЙого ідекс (починаючи з 0): {1}", max, maxi);
WriteLine("\n\nМаксимальний за модулем елемент: {0}", maxmod);
WriteLine("\n\nСума індексів більших за 0 елементів: {0}", sumi);
WriteLine("\n\nКількість цілих чисел: {0}", countZ);

