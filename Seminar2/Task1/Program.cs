System.Console.WriteLine("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arraySize];
Random rand = new Random();

// Заполнение массива
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(10, 100);
}

// Вывод массива
for (int i = 0; i < array.Length; i++)
{
    System.Console.Write(array[i] + " ");
}

Console.WriteLine("\nВведите искомое значение: ");
int findNumber = Convert.ToInt32(Console.ReadLine());
bool numberIsFinder = false;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == findNumber) 
    {
        numberIsFinder = true;
        break;
    }
}

if (numberIsFinder)
    System.Console.WriteLine("Yes!");    
    else
    System.Console.WriteLine("No!");