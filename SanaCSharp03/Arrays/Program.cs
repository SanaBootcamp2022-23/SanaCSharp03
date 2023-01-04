

Console.OutputEncoding = System.Text.Encoding.Default;

Console.Write("Введіть N: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[N];


void FillArrayRandom(int[] arr)
{

    

    Random rand = new Random();

    for (int i = 0; i < N; i++)
    {
        arr[i] = rand.Next(-10, 10);
        Console.WriteLine(arr[i]);
        
    }

}

 void SumaVidemnuhElementiv(int[] arr)
{
    int suma = 0;
    for (int i = 0; i > arr.Length; i++)
        if (arr[i] < 0)
        {
            suma = suma + arr[i];
        }
    Console.WriteLine($"Сума відємних чисел: {suma}");

}

void maxElementiv(int[] arr)
{

    int max = -99;
    for (int i = 0; i < arr.Length; i++)
    {
        if ( arr[i] > max)
        {
            max = arr[i];
        }
    }
    Console.WriteLine($"Максимальний елемент масиву: {max}");
}

void IndexmaxElement(int[] arr)
{
    int max = arr[0];
    int maxIndex = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
            maxIndex = i;

        }
    }
    Console.WriteLine($"Індекс максимального елементу: {maxIndex}");
}

void maxModulElement(int[] arr)
{
    int max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (Math.Abs(arr[i]) > max)
            max = Math.Abs(arr[i]);
    }
    Console.WriteLine($"Максимальний за модулем число: {max}");
}

void sumaIndexDodatElementiv(int[] arr)
{
    int suma = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            suma += i;

        }

    }
    Console.WriteLine($"Сума індексів додатних чисел: {suma}");
}

void kilkstciluhchusel(int[] arr)
{
    int kilk = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 1 == 0)
        {
            kilk++;

        }

    }
    Console.WriteLine($"Кількість цілих чисел: {kilk}");

}





FillArrayRandom(arr);
SumaVidemnuhElementiv(arr);
maxElementiv(arr);
IndexmaxElement(arr);
maxModulElement(arr);
sumaIndexDodatElementiv(arr);
kilkstciluhchusel(arr);








