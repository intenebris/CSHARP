void Main()
{
    int[,] numbers = new int[,]
    {
        {1, 2, 3, 4},
        {5, 6, 7, 8},
        {9, 10, 11, 12}
    };
    PrintArray(numbers);
    int x = numbers.GetLength(0) - 1;
    int y = numbers.GetLength(1) -1;
    System.Console.WriteLine(x + " " + y);
    int[,] newArr = SwapFirstLastRows(numbers);
    System.Console.WriteLine();
    PrintArray(newArr);
    
}

void PrintArray(int[,] array)
    {
        //Напишите свое решение здесь
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }

    // Обмен первой с последней строкой
    int[,] SwapFirstLastRows(int[,] array)
    {
        //Напишите свое решение здесь
        int[,] flipArray = new int[array.GetLength(0), array.GetLength(1)];
        int k = array.GetLength(0) - 1;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                flipArray[i, j] = array[i, j];
            }
        }
        
        for (int i = 0; i < array.GetLength(1); i++)
        {
            flipArray[0, i] = array[k, i];
            flipArray[k, i] = array[0, i];
        }
        return flipArray;
    }

Main();
