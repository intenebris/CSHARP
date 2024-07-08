// Задача 3: Задайте произвольную строку. 
// Выясните, является ли она палиндромом.
// Пример
// “aBcD1ef!-” => Нет 
// “шалаш” => Да 
// “55655” => Да

void Main()
{
    Console.WriteLine("Enter the text: ");
    string? str = Console.ReadLine();
    Console.WriteLine($"Is the string '{str}' a palindrome? {IsPalindromic(str)}");
}

string IsPalindromic(string? str)
{
    string result = "No.";
    if (str == ReversString(str))
    {
        result = "Yes.";
    }
    return result;
}

string ReversString(string? str)
{
    string result = "";
    for (int i = 0, x = str!.Length - 1; i < str!.Length; i++)
    {
        result += str[x];
        x--;
    }
    return result;
}

Main();