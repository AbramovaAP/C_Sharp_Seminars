﻿// -------------------Задание 3. -----------------------

// Напишите программу, которая будет принимать на вход два
// числа и выводить, является ли второе число кратным первому.
// Если второе число некратно первому, то программа выводит
// остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

//Сначала надо задать 2 переменные
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
//Теперь надо задать условие, при котором определяется кратность чисел
//Заранее лучше создам переменную с остатком
int c = a % b;
if (a % b == 0){
    Console.WriteLine("Да");
}
else{
    Console.WriteLine($"Нет, {c}");
}
//Код готов, осталось только проверить