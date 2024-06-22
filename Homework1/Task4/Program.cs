// Внутри класса Answer напишите метод PrintEvenNumbers, которая на вход принимает число (number), 
// а на выходе выводит все чётные числа от 1 до number (включительно), 
// после каждого числа должен быть знак пробела.

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Четные числа: ");
for(int i = 1; i <= number; i++)
{
    if(i % 2 == 0)
    {
        System.Console.Write(i + " ");
    }
}