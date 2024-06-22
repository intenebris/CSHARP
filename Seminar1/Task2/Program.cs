// Задание 2. Совместная работа
// Семинар 1. Знакомство с языками программирования 
// Напишите программу, которая на вход принимает целое число N, 
// а на выходе показывает все целые числа в промежутке от -N до N. 
// Примеры 
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4 
// 2 => -2, -1, 0, 1, 2

System.Console.WriteLine("Введите целое число N:    ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Вы ввели: " + number);
// if(number < 0)
// {
//     System.Console.WriteLine("Вы ввели некоректное число");
// }

// int i = -number;
// while(i <= number)
// {
//     System.Console.Write(i + " ");
//     i++;
// }

for(int i = -number; i < number; i++)
    System.Console.Write(i + ", ");
System.Console.Write(number);