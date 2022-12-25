Console.WriteLine("Enter N:");
int n=int.Parse(Console.ReadLine());
int[] arr = new int[n];
int countNegative = 0;
int SumOfPositiveIndexes = 0;


for (int i = 0; i < n; i++)
{
    Random r = new Random();    
    arr[i] = r.Next(-100,100);      
    Console.Write($"{arr[i]}\t");
}
for (int i = 0; i < arr.Length; i++)
{
    if(arr[i] < 0) { countNegative++; }
    if(arr[i] > 0) { SumOfPositiveIndexes+=i; }   
}
int MaxElement = arr.Max();
int MaxAbsValue= arr.Select(x => Math.Abs(x)).Max();
Console.WriteLine($"\n\nThe sum of negative elements: {countNegative}\n" +
    $"The max element: {MaxElement}\n" +
    $"Index of max element: {Array.IndexOf(arr,MaxElement)}\n" +
    $"The max absolute element: {MaxAbsValue}\n" +
    $"The sum of positive element's endexes: {SumOfPositiveIndexes}");
