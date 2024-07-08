// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные. 
// Пример
// “aBcD1ef!-” => “abcd1ef!-” 

void Main()
{
    string str = "aBcD1ef!-";
    string result = str.ToLower();
    System.Console.WriteLine(result);

}


Main();