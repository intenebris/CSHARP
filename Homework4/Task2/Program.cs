// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

void Main()
{
    int[] array = GenerateArray(10, 100, 999);
    int result = GetEvenNumbers(array);
    System.Console.WriteLine("Создан массив:");
    PrintArray(array);
    System.Console.Write("\nЧисло четных чисел в массиве: ");
    System.Console.Write(result);
}

int GetEvenNumbers(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            counter++;
        }
    }
    return counter;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] GenerateArray(int size, int minValue, int maxValue)
{
    Random rand = new Random();
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(minValue, maxValue + 1);
    }
    return array;
}
Main();