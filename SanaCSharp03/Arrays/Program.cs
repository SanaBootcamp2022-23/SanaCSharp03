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
double max_for_modul = arr[0];
for (int i = 0; i < n; i++)
{
    arr[i]= int.Parse(Console.ReadLine());
    if (arr[i] < 0)
    {
        sum_min += arr[i];
    }
    if (arr[i] > max)
    {
        max = arr[i];
        ind_max = i+1;
    }



}
Console.WriteLine("Суму від’ємних елементів масиву " + sum_min); 
Console.WriteLine("Максимальний елемент масиву " + max); 
Console.WriteLine("Номер (індекс) максимального елемента масив " + ind_max); 


