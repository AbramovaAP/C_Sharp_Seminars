﻿// -----------------Задача 4-----------------
// Напишите программу, которая на вход
// принимает натуральное число N, а на выходе
// показывает его цифры через запятую.
//Например: 
// 568 => 5,6,8
// 8 => 8
// 9542 => 9,5,4,2

// Мое решение 
Console.Write("Введите число: ");
string s = Console.ReadLine();

for (int i=0; i < s.Length-1; i++) {
    Console.Write($"{s[i]}, ");
}
Console.Write($"{s[s.Length-1]}");
   // Решение с ответов, результат чисел почему-то перевернут
// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());

// if (N < 10) {Console.Write(N);}
// else {
//     while (N > 0) {
//         int result = N % 10;
//         N/=10;
//         if (N > 0) {
//             Console.Write(result + ", ");
//         }
//         else {Console.Write(result);}
//     }
// }