// Внутри класса Answer напишите метод FindMax, 
// который принимает на вход три числа и выдаёт 
// максимальное из этих чисел.

System.Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

int maxNumber = a;

if(maxNumber < b)
{
    maxNumber = b;
    if(maxNumber < c)
    {
        maxNumber = c;
        System.Console.WriteLine("Максимальное число: " + c);
    }else
    {
        System.Console.WriteLine("Максимальное число: " + b);
    }
}else 
{
    System.Console.WriteLine("Максимальное число: " + a);
}

