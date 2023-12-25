// ---------------------Задание 2.----------------------

// Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную
// третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

//=============Решение 1=====================
// //вводим число
// using System.Runtime.ExceptionServices;

// int input = int.Parse(Console.ReadLine());
// //Получаем третью цифру
// int ThirdNumber=input%10;
// //Получаем вторую цифру
// //Число- XYZ = X*100+Y*10+Z. Y=(XYZ-X*100-Z)/10
// int SecondNumber=(input-(input/100 * 100)- input%10)/10;

// //Возводим в степень
// Console.WriteLine("Третье число: "+ThirdNumber+" ,второе число: "+SecondNumber );
// // Вот пока не изучил- как перевести int в Double? 
// Console.WriteLine("Результат возведения в степень: "+ SecondNumber + "^ "+ThirdNumber+ " " +Math.Pow( SecondNumber,ThirdNumber ));
// //Третье число в степени равной второму.

//=============Решение 2=====================
int n = new Random().Next(100, 1000);
int a = n % 100;
Console.WriteLine(a);
a = a / 10;
Console.WriteLine(a);
int b = n % 10;
Console.WriteLine(b);
double c = Math.Pow(a, b);
Console.WriteLine($"{n} => {a}^{b} => {c}");