﻿// ---------------------Задание 2.----------------------

// Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную
// третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

//=============Решение 1=====================
//вводим число
int input = int.Parse(Console.ReadLine());
//Трехзначное число состоит (X - первое число, Y - второе число, Z - третье число).
//XYZ = X*100+Y*10+Z. => Y=(XYZ-X*100-Z)/10
//Получаем третью цифру (Z)
int ThirdNumber = input % 10; // 123 % 10 = 12,3 => Z = 3.
//Получаем вторую цифру
int SecondNumber = (input - (input / 100 * 100) - input % 10) / 10;

// Разбор формулы второй переменной (Y):
//      input / 100 * 100 = 100 - Означает: 
// 1. input / 100 = 123 / 100 = 1,00 (а не 1,23 потому что тип переменной integer)
// 2. input / 100 * 100 = 1,00 * 100 = 100
//      input - (input / 100 * 100) = 123 - 100 = 23
//      (input - (input / 100 * 100) - input % 10) = (123 - 100 - 3) = 20
//      (input - (input / 100 * 100) - input % 10) / 10 = 20 / 10 = 2 - второе число получено

//Выводим второе и третьи числа:
Console.WriteLine("Второе число: " + SecondNumber + ", третье число: " + ThirdNumber);
//Возводим третье число в степень, которая равна второму числу (Z ^ Y)
Console.WriteLine("Результат возведения в степень: " + SecondNumber + " ^ " + ThirdNumber + 
                  " = " + Math.Pow( SecondNumber,ThirdNumber ));

//=============Решение 2=====================
// int n = new Random().Next(100, 1000);
// int a = n % 100;
// Console.WriteLine(a);
// a = a / 10;
// Console.WriteLine(a);
// int b = n % 10;
// Console.WriteLine(b);
// double c = Math.Pow(a, b);
// Console.WriteLine($"{n} => {a}^{b} => {c}");