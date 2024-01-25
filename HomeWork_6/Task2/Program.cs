//=====Задача 2=========
//Задайте строку, содержащую латинские буквы в обоих регистрах. 
//Сформируйте строку, в которой все заглавные буквы заменены на строчные.

// Задаем строку, содержащую латинские буквы в обоих регистрах
string st = "ПрИвЕт, КаК ТвОи ДеЛа?";

Console.WriteLine("Исходный двумерный массив:");
Console.Write(st);
Console.WriteLine();

Console.WriteLine("Измененная строка:");
Console.WriteLine(st.ToLower());

//ИДЕАЛЬНОЕ РЕШЕНИЕ С ПОРТАЛА:
// public class Task2
// {
// public static void Main(string[] args)
// {
// // Входная строка со смешанными буквами обоих регистровstring input = "aBcD1ef!-";
// // Преобразование всех заглавных букв в строчные
// string result = input.ToLower();
// // Вывод результата
// Console.WriteLine(result);
// }
// }