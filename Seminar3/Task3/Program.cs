// Задание 1. Задайте одномерный массив, 
// заполненный случайными числами. 
// Определите количество простых чисел в этом массиве. 
// Примеры 
// [1 3 4 19 3] => 2 
// [4 3 4 1 9 5 21 13]  => 3
void Main()
{
    int arraySize = ReadInt("Введите размер массива: ");
    int[] array = GenerateArray(arraySize, 0, 20);
    PrintArray(array);
    System.Console.WriteLine(CountPrimary(array));
}

int CountPrimary(int[] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if(isPrimary(item))
        {
            count++;
        }
    }
    return count;
}

bool isPrimary(int number)
{
    if (number < 2)
        return false;
    for (int i = 2; i <= Math.Sqrt(number); i++)
        if (number % i == 0)
            return false;

    return true;
}

int[] GenerateArray(int size, int minValue, int maxValue)
{
    int[] tempArray = new int[size];
    Random rand = new Random();
    for (int i = 0; i < tempArray.Length; i++)
        tempArray[i] = rand.Next(minValue, maxValue + 1);
    return tempArray;
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(System.Console.ReadLine());
}

void PrintArray(int[] arrayForPrint)
{
    System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}

Main();