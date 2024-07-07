// Задание 3. Считать строку с консоли, 
// состоящую из латинских букв в нижнем регистре. 
// Выяснить, сколько среди введённых букв гласных. 
// Пример 
// “hello” => 2 
//“world” => 1

void Main()
{
    Console.WriteLine("Введите строку: ");
    string? str = System.Console.ReadLine();
    Console.WriteLine(CountVowels(str));
}

int CountVowels(string? str)
{
    int count = 0;
    str = str!.ToLower();
    foreach (char c in str)
    {
        if(isVowel(c))
        {
            count++;
        }
    }
    return count;
}

bool isVowel(char c)
{
    return "aeiouy".Contains(c);
}



Main();