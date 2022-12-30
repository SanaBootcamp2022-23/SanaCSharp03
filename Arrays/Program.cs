using System.Text;

int n, max_index=0 , count_int = 0,index_module_max=0;
double sum_negative =0 , max,  module_max, sum_index = 0;
Console.OutputEncoding = UTF8Encoding.UTF8;
Console.WriteLine("Будь ласка введіть кількість елементів у масиві");
n = Convert.ToInt32(Console.ReadLine());
double[] arr = new double[n];

Console.WriteLine("Будь ласка введіть елементи масиву (дійсні числа)");
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Convert.ToDouble(Console.ReadLine());
}
max = arr[0];
module_max = arr[0];
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i]<0)
    { sum_negative += arr[i]; }

    if (arr[i]>0)
    {sum_index += i;}
    if (arr[i]>max)
    { max = arr[i];
      max_index = i;
    }
    if (Math.Abs(arr[i]) > module_max)
    {
     module_max = Math.Abs(arr[i]);
        index_module_max = i;

    }
    if (arr[i]%1==0)
    {
        count_int += 1;
    }
}





//Console.WriteLine(arr.Length);
Console.WriteLine($"\nсума від’ємних елементів масиву: {sum_negative}\n" +
    $"максимальний елемент масиву: {max}\n" +
    $"номер (індекс) максимального елемента масиву: {max_index}\n" +
    $"максимальний за модулем елемент масиву: {arr[index_module_max]}\n" +
    $"сума індексів додатних елементів: {sum_index}\n" +
    $"кількість цілих чисел у масиві: {count_int}");