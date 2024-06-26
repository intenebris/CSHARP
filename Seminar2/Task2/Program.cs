int[] array = new int[10];
Random rand = new Random();

// Заполнение массива
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-10, 11);
}

// Заполнение массива
for (int i = 0; i < array.Length; i++)
{
    System.Console.Write(array[i] + "\t");
}

// Меняем значение чисел
for (int i = 0; i < array.Length; i++)
{
    array[i] *= -1;
}
System.Console.WriteLine("\nЗаменяем эллементы: ");
// Заполнение массива
for (int i = 0; i < array.Length; i++)
{
    System.Console.Write(array[i] + "\t");
}