// Задание 3*. Работа в сессионных залах 
// Напишите программу, которая принимает на вход трёхзначное целое число 
// и на выходе показывает сумму первой и последней цифры этого числа. 
// 456  =>  10 
// 782  =>  9 
// 918  =>  17

System.Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 99 && number < 1000)
{
    int firstDigit = number / 100;
    int thirdDigit = number % 10;
    int sum = firstDigit + thirdDigit;
    System.Console.WriteLine("Сумма первой и последней цифры = " + sum);
}
else{
    System.Console.WriteLine("Введено не трехзначное число!!!");
}