// Задача 1: Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива. 

// a b c   => “abcdef”
// d e f 

void Main()
{
    char[,] chars = 
    {
        { 'a', 'b', 'c'},
        { 'd', 'e', 'f' }
    };
    char[] chars2 = { 'a', 'b', 'c'};
    System.Console.WriteLine(CreateStringFromArray(chars));

}


string CreateStringFromArray(char[,] chars)
{
    string str = "";
    for (int i = 0; i < chars.GetLength(0); i++)
    {
        for (int j = 0; j < chars.GetLength(1); j++)
        {
            str += chars[i, j];
        }
    }
    return str;
}

Main();
