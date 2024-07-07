// Задание 2. На основе символов строки (тип string) 
// сформировать массив символов (тип char[]). 
// Вывести массив на экран. 

// Указание 
// Метод строки ToCharArray() не использовать. 
// Пример 
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ] 

void Main()
{
    string? str = System.Console.ReadLine();

    // 1-ый способ
    // char[] chars = str.ToCharArray();

    // 2-ой способ
    char[] chars= StringToChar(str);
    PrintCharArray(chars);
}

char[] StringToChar(string? str)
{
    char[] chars = new char[str!.Length];

    for (int i = 0; i < str.Length; i++)
    {
        chars[i] = str[i];
    }
    return chars;
}

void PrintCharArray(char[] chars)
{
    System.Console.WriteLine(string.Join(", ", chars));
}

Main();