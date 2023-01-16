// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Введіть число n : ");
int n =int.Parse(Console.ReadLine());
double[]arr=new double[n];
double sum_min=0;   
double max = arr[0];
int ind_max=0;
double max_for_modul_numb = Math.Abs(arr[0]);
int max_ind_modul=0;
int sum_ind=0;
int a;
double b;
int numb_int = 0;

Console.WriteLine("Введіть числа масиву : ");





for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Введіть число {i + 1} : ");
    arr[i] = double.Parse(Console.ReadLine());
    if (arr[i] < 0)
    {
        sum_min += arr[i];
    }
    if (arr[i] > max)
    {
        max = arr[i];
        ind_max = i;
    }
    if(Math.Abs(arr[i]) > max_for_modul_numb)
    {
        max_for_modul_numb = Math.Abs(arr[i]);
        max_ind_modul = i;
    }
    if (arr[i] > 0)
    {
        sum_ind+= i;
    }
    

}
Console.WriteLine("Суму від’ємних елементів масиву " + sum_min); 
Console.WriteLine("Максимальний елемент масиву " + max); 
Console.WriteLine("Номер (індекс) максимального елемента масив " + ind_max); 
Console.WriteLine("Максимальний за модулем елемент масиву " + max_ind_modul); 
Console.WriteLine("Суму індексів додатних елементів " + sum_ind);





for (int i = 0; i < n; i++)
{
    a = Convert.ToInt32(arr[i]);
    b = arr[i];
    if (a == b)
    {
        numb_int++;
    }
}
Console.WriteLine("Кількість цілих чисел у масиві " + numb_int);




