// Внутри класса Answer напишите метод CheckIfEven, 
// который на вход принимает число number и выводит, 
// является ли число чётным (делится ли оно на два без остатка).

System.Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int checkNumber = number % 2;
if(checkNumber == 0)
{
    System.Console.WriteLine("четное");
}else
{
    System.Console.WriteLine("нечетное");
}