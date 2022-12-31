Console.Write("Enter array size: ");
int N = Convert.ToInt32(Console.ReadLine());
double[] a = new double[N];
Console.WriteLine("Enter array: ");
for (int i = 0; i < N; i++)
{
    double q = Convert.ToDouble(Console.ReadLine());
    a[i] = q;
}

double sumn = 0, max = a[0], maxi = 0, maxm = a[0], sumip = 0, si = 0;
for (int i = 0; i < N; i++)
{
    if (a[i] > max)
    {
        max = a[i];
        maxi = i;
    }
    if (a[i] < 0)
    {
        sumn += a[i];
    }
    if (Math.Abs(a[i]) > Math.Abs(maxm))
    {
        maxm = a[i];
    }
    if (a[i] > 0)
    {
        sumip += i;
    }
    if ((int) a[i] == a[i])
    {
        si++;
    }
}

Console.WriteLine("Sum of negative elements: " + sumn);
Console.WriteLine("Max element: " + max);
Console.WriteLine("Max element index: " + maxi);
Console.WriteLine("Max module element: " + maxm);
Console.WriteLine("Sum of positive elements indexes: " + sumip);
Console.WriteLine("Integers: " + si);

