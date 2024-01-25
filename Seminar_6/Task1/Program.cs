//=============Задача 1==============
// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.
// Указание:
// Конструктор строки вида string(char []) не использовать.
// Пример:
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

//Задайте массив символов (тип char []). Создайте строку из символов этого массива. 
string CharOfString(char[] arr)
{
    string st = "";
    foreach (var item in arr)
    {
        st += item;
    }
    return st;
}

char[] chars = new char[] {'a', 'b', 'c', 'd', 'e'};
Console.WriteLine(CharOfString(chars));