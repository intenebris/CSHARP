// Задача 3: Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

void Main()
{
    int[] array = GenerateArray(10, 10, 99);
    int[] flipedArray = FlipArray(array);
    System.Console.WriteLine("Был создан одномерный массив:");
    PrintArray(array);
    System.Console.WriteLine("\nПеревернутый массив:");
    PrintArray(flipedArray);
}

int[] FlipArray(int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[array.Length - 1 - i];
    }
    return result;
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

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Main();