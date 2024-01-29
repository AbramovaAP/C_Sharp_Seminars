//========Задача 3==============
// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.
// Указание:
//          Использовать рекурсию. Не использовать цикл.
// Пример:
//          “hello” => h l l
//          “World” => W r l d
//          “Hello world!” => H l l w r l d

//============= Решение ==============
void String(string s)
{
    if (s.Length == 0) return;
    string volvels = "aoueiy";
    if (volvels.Contains(s[0]) == false)
    {Console.Write($"{s[0]} ");}
    String(s[1..]);
}

string st = Console.ReadLine()!;
String(st);