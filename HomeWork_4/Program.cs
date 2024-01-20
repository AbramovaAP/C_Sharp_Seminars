﻿//=============================Задача 1================================================
//Напишите программу, которая бесконечно запрашивает целые числа с консоли.
//Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

// using System;
// class Program
// {
//     static void Main()
//     {
//         while (true) // Бесконечный цикл
//         {
//             Console.Write("Введите любое число или 'q' для выхода: ");
//             string input = Console.ReadLine(); // Чтение строки ввода пользователя
            
//             if (input == "q") { // Проверка на ввод 'q' для выхода
//                 break;
//             }

//             int number;
//             if (int.TryParse(input, out number)) {// Проверка, является ли ввод числом{
//                 int sum = 0;
//                     while (number > 0) { // Вычисление суммы цифр числа
//                     sum += number % 10; // Добавление последней цифры к сумме
//                     number /= 10; // Удаление последней цифры из числа
//                     }

//                 if (sum % 2 == 0){ // Проверка, является ли сумма цифр четной
//                 Console.WriteLine("[STOP]");
//                 break;
//                 }
//             }

//             else // Если ввод не является числом и не 'q', повторить запрос
//             {
//             Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q': ");
//             }
//         }
//     }
// }


//===============================================================================================================
//===============================================================================================================


//===================Задача 2=============================
//Задайте массив заполненный случайными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//Решение с платформы(идеальное)
// using System;
// class Program
// {
//     static void Main()
//     {
//         int[] numbers = new int[10]; // Массив для хранения случайных чисел
//         Random random = new Random(); // Генератор случайных чисел
//         int evenCount = 0; // Счетчик четных чисел
//                            // Заполнение массива случайными трехзначными числами
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = random.Next(100, 1000); // Случайное число от 100 до 999
//             Console.Write(numbers[i] + " "); // Вывод сгенерированного числа
//                                              // Проверка на четность и увеличение счетчика
//             if (numbers[i] % 2 == 0)
//             {
//                 evenCount++;
//             }
//         }
//         // Вывод количества четных чисел в массиве
//         Console.WriteLine($"\nКоличество четных чисел в массиве: {evenCount}");
//     }
// }


//Мое решение:
// //1. Создаем команду, которая на вход будет принимать размерность массива:
// Console.Write("Введите размерность массива: ");
// int n = Convert.ToInt32(Console.ReadLine());

// //2. Создать массив из N случайных целых трехзначных чисел
// int[] Array_rnd(int n) {
//     int[] array = new int[n]; //- сначала задаем пустой массив размерностью n, чтобы потом записать в него числа
//     //цикл для перебора случайных цифр и заполнение ими массива
//     for (int i = 0; i < n; i++)
//     {
//         array[i] = new Random().Next(100, 1000); // Случайное число от 100 до 999
//     }
//     return array; //возвращаем(запоминаем) заполненный массив
// }
// //3. Выводим массив случайных чисел 
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// int[] array = Array_rnd(n);//записываем созданный массив в отдельную переменную
// PrintArray(array); //запускаем функцию PrintArray с переменной array, для печати массива в консоли

// //4. Формируем число из элементов массива
// int Numbers(int[] arr)
// {
//     int evenCount = 0; //переменная, отвечающая за количество четных чисел
//     for (int i = 0; i < arr.Length; i++){
//         if (arr[i] % 2 == 0)
//             {
//                 evenCount++;
//             }
//     }
//     return evenCount;
// }

// int Count = Numbers(array); //записываем количество четных чисел в отдельную переменную
// Console.WriteLine($"\nКоличество четных чисел в массиве: {Count}"); // Выводим получившееся число на консоль

// //======================================================================================================
// //======================================================================================================


// //======================Задача 3================================
// //Напишите программу, которая перевернёт одномерный массив 
// //(первый элемент станет последним, второй – предпоследним и т.д.)

using System;
class Program
{
    static void Main()
    {
        int[] numbers = { 1, 3, 5, 6, 7, 8 }; // Исходный массив
        int temp;
        // Вывод исходного массива
        Console.Write("Исходный массив: ");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        // Реверсирование массива
        for (int i = 0; i < numbers.Length / 2; i++)
        {
            // Меняем местами элементы
            temp = numbers[i];
            numbers[i] = numbers[numbers.Length - 1 - i];
            numbers[numbers.Length - 1 - i] = temp;
        }
        // Вывод измененного массива
        Console.Write("\nПеревернутый массив: ");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}