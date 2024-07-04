// Задача 1: 
// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, 
// сумма цифр которого чётная.

void Main()
{
    RequestIntegerInConsole();
}

int GetSumOfNumbers(int digit)
{
    int sum = 0;
    int number = digit;
    if (digit < 0)
    {
        number = digit * -1;
    }
    while (number > 0)
    {
        sum = sum + number % 10; // 248 - 0+8, 24 - 8+4, 2 - 12 + 2 = 14
        number = number / 10; // 24, 2, 0
    }
    return sum;

}

bool isEven(int digit)
{
    if (GetSumOfNumbers(digit) % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

void RequestIntegerInConsole()
{
    int number = 0;
    int sum = 0;
    while (true)
    {
        System.Console.WriteLine("Введите целое число: ");
        number = Convert.ToInt32(Console.ReadLine());
        sum = GetSumOfNumbers(number);
        if (isEven(sum))
        {
            break;
        }
    }
}

Main();