// Вычисление факториала от натурального числа N

int Fact(int n)
{
    if(n == 1 || n ==0)
    {
        System.Console.WriteLine($"Stop: {n}");
        return 1;
    }
    System.Console.Write(" " + n);
    return n * Fact(n-1);
}

System.Console.WriteLine(Fact(18));