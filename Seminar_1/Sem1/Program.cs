//              Задание 1. Совместная работа
// Напишите программу, которая на вход принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10  => нет 
// a = 9, b = -3  => да
// a = -3, b = 9  => нет

// Console.Write("Введите первое число: ");
// int number1 = int.Parse(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int number2 = int.Parse(Console.ReadLine());

// if (number1 * number1 == number2) 
//     {
//         Console.WriteLine("Является!");
//     }
// else if (number1 == number2 * number2) 
//     {
//         Console.WriteLine("Является!");
//     }
// else 
//     {
//         Console.WriteLine("Не является!");
//     }

//__________________________________________________________________

//              Задание 2. Совместная работа
// Напишите программу, которая на вход принимает целое число N, а на выходе показывает все целые числа в промежутке от -N до N.
// Примеры:
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// if (num < 0)
// {
//     num = num * (-1);
// }
// int counter = -num;

// while (counter <= num)
// {
//     Console.Write($"{counter} ");
//     counter = counter +1; //тоже самое, что и 'counter++'
// }

//__________________________________________________________________

//               Задание 3*. Работа в сессионных залах
// Напишите программу, которая принимает на вход трёхзначное 
//целое число и на выходе показывает сумму первой и последней 
//цифры этого числа.
// 456  =>  10
// 782  =>  9
// 918  =>  17

                    // Решение 1

// Сначала считаем число с консоли
// int input =int.Parse(Console.ReadLine());

// // Теперь нам нужно получить первую и последнюю цифры. Это можно сделать с помощью операции остатка от деления на 100 и на 10
// // Остаток от деления  - A%B

// int DecimalLeftover= input%100;
// int FirstNumber= input-DecimalLeftover;

// // Получаем остаток от деления. 
// //Вычтя остаток от деления- получаем по сути деление без остатка, 
// //но без самого деления.

// FirstNumber = FirstNumber/100;

// //Т.к. у нас будет лежать именно первая цифра и два нуля.
// // Теперь получим третью цифру. Это остаток от деления на 10.

// int LastNumber = input%10;
// // Сумма 
// int Result = FirstNumber + LastNumber;
// //Выведем результат
// Console.WriteLine(Result);

                    // Решение 2

// Console.WriteLine (input / 100 + input % 10);

                    // Решение 3

// Console.Write("Введите трёхзначное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int a = n % 100;
// a = a % 10;
// int b = n / 100;
// int c = a + b;
// Console.WriteLine($"Сумма первой и последней цифры - {c}.");

                    // Решение 4
Console.Write("Введите трёхзначное число: ");
string n = Console.ReadLine();
int num1 = Convert.ToInt32(Convert.ToString(n[0]));
int num2 = Convert.ToInt32(Convert.ToString(n[2]));
Console.WriteLine(num1 + num2);