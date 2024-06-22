int n = 5;
int[] array = { 14, 6, 27, 8, 9 };
int max = 0;

for (int i = 0; i < n; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
}
System.Console.WriteLine(max);

max = array[0];
foreach (int e in array)
{
    if (e > max)
    {
        max = e;
    }
}
System.Console.Write($"{max} ");
