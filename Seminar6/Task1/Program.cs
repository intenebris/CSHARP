// Задание 1. Задайте массив символов (тип char []). 
// Создайте строку из символов этого массива. 
// Указание 
// Конструктор строки вида string(char []) не использовать. 
// Пример 
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

void Main()
{
    char[] chars = {'a', 'b', 'c', 'd'};

    // 1-ый способ:
    // string str = new string(chars);
    // System.Console.WriteLine(str);

    // 2-ой способ:
    // System.Console.WriteLine(CharsToStrings(chars));

    // 3-ий способ:
    // System.Console.WriteLine(string.Join("", chars));

    // 4-ый метод:
    System.Console.WriteLine(string.Concat(chars));

}

// string CharsToStrings(char[] chars)
// {
//     string str = "";
//     foreach (char c in chars)
//     {
//         str += c;
//     }
//     return str;
// }

Main();