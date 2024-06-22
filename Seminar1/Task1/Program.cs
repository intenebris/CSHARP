// Напишите программу, которая на вход принимает два целых числа и проверяет, является ли первое число квадратом второго. 
// a = 25, b = 5 => да 
// a = 2,  b = 10 => нет 
// a = 9,  b = -3  => да 
// a = -3, b = 9   => нет

// int firstNumber = 2;
// int secondNumber = 10;
System.Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Вы ввели: " + secondNumber);

if(firstNumber == secondNumber * secondNumber)
{
    System.Console.WriteLine($"a = {firstNumber}, b = {secondNumber} => да");
}
else
{
    System.Console.WriteLine($"a = {firstNumber}, b = {secondNumber} => нет");
}


