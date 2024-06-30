// Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,90].

// Начальные условия:

// int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива
// Выводится: 5

// int[] array = new int[10];
// Random rand = new Random();

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(10, 91);
// }

int[] numbers = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3};
int minRange = 0;
int maxRange = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == 20)
    {
        minRange = i;
    } else if (numbers[i] == 90)
    {
        maxRange = i;
    }
}
System.Console.WriteLine(maxRange - minRange);