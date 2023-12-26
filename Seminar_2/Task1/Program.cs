// -------------Задание 1.-------------------
// Напишите программу, которая принимает на вход
// трёхзначное число и удаляет вторую цифру этого
// числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

// //----------Вариант решения 1------------------
int num = new Random().Next(100, 1000); //new Random().Next(100, 999)- где 100 входит в промежуток, 
                                    //а 999 нет, поэтому пишем 1000

int num1 = num / 100; // остатка от деления в C# не будет,
                      // т.к. тип integer
int num2 = num % 10;

Console.WriteLine(num);
// Console.WriteLine(num1 + "" + num2);
// Console.WriteLine(num1 * 10 + num2);

// // Для красивого вывода:
Console.WriteLine($"{num} => {num1 * 10 + num2}");

//--------------Вариант решения 2-----------------------
// int num = new Random().Next(100, 1000);

// string num1 = Convert.ToString(num / 100);
// string num2 = Convert.ToString(num % 10);

// Console.WriteLine(num);
// Console.WriteLine(num1 + num2);