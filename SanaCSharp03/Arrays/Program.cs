class Program
{
    public static void arr(int[] iS, int min = -10, int max = 11)
    {
        Random rand = new Random();
        for (int i = 0; i < iS.Length; i++)
        {
            iS[i] = rand.Next(min, max);
        }
    }
    public static int first(int[] iS)
    {
        int sum = 0;
        for (int i = 0; i < iS.Length; i++)
            if (iS[i] < 0)
            {
                sum += iS[i];
            }
        return sum;
    }
    public static int second(int[] iS)
    {
        int max = iS[0], j, k = 0;
        for (int i = 0; i < iS.Length; i++)
        {
            if (iS[i] > max)
            {
                max = iS[i];
            }
        }
        return max;

    }
    public static int fourth(int[] iS)
    {
        int j = 1;
        int max1 = iS[0];
        for (int i = 1; i < iS.Length; i++)
            if (max1 < iS[i])
            {
                max1 = iS[i];
                j = i;
            }
        return j;
    }
    static int fifth(int[] iS)
    {
        int max2 = Math.Abs(iS[0]);
        for (int i = 1; i < iS.Length; i++)
            if (max2 < Math.Abs(iS[i]))
                max2 = iS[i];
        return max2;
    }
    static int sixth(int[] iS)
    {
        int sum = 0;
        for (int i = 0; i < iS.Length; i++)
            if (iS[i] > 0)
                sum += i;
        return sum;
    }
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Default;
        Console.Write("Введіть розмір масиву: ");
        int n = int.Parse(Console.ReadLine());
        int[] jS = new int[n];
        arr(jS);
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"arr[{i}] = {jS[i]}");
        }
        Console.WriteLine($"Cумa від’ємних елементів масиву: {first(jS)}");
        Console.WriteLine($"Максимальний елемент масиву: {second(jS)}");
        Console.WriteLine($"Номер (індекс) максимального елемента масиву: {fourth(jS)}");
        Console.WriteLine($"Максимальний за модулем елемент масиву: {fifth(jS)}");
        Console.WriteLine($"Сума індексів додатних елементів: {sixth(jS)}");
    }
}