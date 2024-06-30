string GetLettersFromString(string s)
{
    string letters = "";
    foreach (char c in s)
    {
        if (char.IsAsciiLetter(c) == true)
        {
            letters += c;
        }
    }
    return letters;
}
System.Console.WriteLine("Введите текст:");
string str = Console.ReadLine();
string result = GetLettersFromString(str);
System.Console.WriteLine(result);