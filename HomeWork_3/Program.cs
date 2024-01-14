//==================Задача 1========================
//Задайте одномерный массив из 10 целых чисел от 1 до 100. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,90].
//Начальные условия:
//int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива
//Выводится: 5

//Мой рабочий вариант без случайного массива

//int[] numbers = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива

//Выведем массив для наглядности:
//         for(int i = 0; i < array.Length; i++){ 
//             Console.Write($"{array[i]} ");
//         } 
//         Console.WriteLine();// пробел

//int counter = 0; //счетчик
//       int minRange = 10;
//        int maxRange = 90;

//Подсчитаем кол-во элементов между 10 и 90
        // for(int i = 0; i < numbers.Length; i++){
        //     if (numbers[i] >= minRange & numbers[i] <= maxRange) {
        //         counter++; // counter = counter + 1
        //     }
        // }
//         }
//         Console.WriteLine(counter);


//================Решение для автотеста 1======================================
// using System;
// using System.Linq;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// { 
//     // Подсчет количества элементов массива, попадающих в заданный диапазон
//     // numbers - массив, в котором ведется подсчет
//     // minRange - минимальная граница диапазона
//     // maxRange - максимальная граница диапазона
//     public static int CountItemsRange(int[] numbers, int minRange, int maxRange)
//     {
//     //Числа для проверки:
// //20, 50, 10, 10, 60, 30, 70, 98, 20, 40
// //10, 50, 10, 1, 1, 30, 70, 91, 1, 1 
// //2, 4, 6, 8, 10, 30, 70, 100, 10, 10 

//         int counter = 0; //счетчик
//         minRange = 10;
//         maxRange = 90;

// //Подсчитаем кол-во элементов между 10 и 90
//         for(int i = 0; i < numbers.Length; i++){
//             if (numbers[i] >= minRange & numbers[i] <= maxRange) {
//                 counter++; // counter = counter + 1
//             }
//         }
//     return counter;
//     }
//     public static void PrintResult(int[] array)
//     {
//         Console.WriteLine(CountItemsRange(array, 10, 90));
//     }

// }


// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {
//         int[] array;
        

//         if (args.Length >= 1) {
//             // Объединяем все аргументы командной строки в одну строку
//             string joinedArgs = string.Join(" ", args);

//             // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
//             array = joinedArgs.Split(", ")
//                                   .Select(int.Parse)
//                                   .ToArray();
            
//             // Теперь arr содержит преобразованные в целые числа из командной строки
        
//         } else {
//            // Если аргументов на входе нет
//             array = new int[] {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива
//         }
//         UserInputToCompileForTest.PrintResult(array);
//     }
// }


//===================================================================================================================================================================
//===================================================================================================================================================================




//===========================Задача 2===================================
//Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.
//Начальные условия:
//int[] array = {2, 5, 2, 3, 6, 3, 7, 8, 2, 4}; // Создание массива
//Выводится: 6

// //Мой рабочий вариант без случайного массива
//         int[] array = new int[] {2, 5, 7, 3, 6, 3, 7, 8, 3, 4}; //Задали одномерный массив из 10 целых чисел. 
//         int counter = 0; //счетчик

// //Выведем массив для наглядности:
//         for(int i = 0; i < array.Length; i++){ 
//             Console.Write($"{array[i]} ");
//         } 
//         Console.WriteLine();// пробел

// //Подсчитаем кол-во четных элементов
//         for(int i = 0; i < array.Length; i++){
//             if (array[i] % 2 == 0) {
//                 counter++; // counter = counter + 1
//             }
//         }
//         Console.WriteLine(counter);


// //================Решение для автотеста======================================
// using System;
// using System.Linq;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// { 
//     // Подсчет количества четных элементов массива
//     // numbers - массив, в котором ведется подсчет
//     public static int CountEvenItems(int[] numbers)
//     {
// //Напишите свое решение здесь
//         int counter = 0; //счетчик

// //Подсчитаем кол-во четных элементов
//         for(int i = 0; i < numbers.Length; i++){
//             if (numbers[i] % 2 == 0) {
//                 counter++; // counter = counter + 1
//             }
//         }
//         return counter;
//     }
    
//     public static void PrintResult(int[] array)
//     {
//         //Напишите свое решение здесь
//         Console.WriteLine(CountEvenItems(array));
//     }
    
// }

// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {
//         int[] array;
        

//         if (args.Length >= 1) {
//             // Объединяем все аргументы командной строки в одну строку
//             string joinedArgs = string.Join(" ", args);

//             // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
//             array = joinedArgs.Split(", ")
//                                   .Select(int.Parse)
//                                   .ToArray();
            
//             // Теперь arr содержит преобразованные в целые числа из командной строки
        
//         } else {
//            // Если аргументов на входе нет
//             array = new int[] {2, 8, 7, 3, 7, 3, 7, 7, 2, 4}; // Создание массива
//         }
//         UserInputToCompileForTest.PrintResult(array);
//     }
// }




//===================================================================================================================================================================
//===================================================================================================================================================================




//===========================Задача 3===================================
//Задайте массив из вещественных чисел с ненулевой дробной частью. 
//Найдите разницу между максимальным и минимальным элементов массива.
//Начальные условия:
//int[] array = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; // Создание массива
//Выводится: 5.15

//Мой рабочий вариант без случайного массива
//         double[] array = new double[] {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; //Задали одномерный массив из 10 целых чисел. 
//         double max = array[0];
//         double min = array[0];

// //Выведем массив для наглядности:
//         for(int i = 0; i < array.Length; i++){ 
//             Console.Write($"{array[i]} ");
//         } 
//         Console.WriteLine();// пробел

// //найдем min и max элементы
//         for(int i = 0; i < array.Length; i++){ 
//             if (array[i] > max) {
//                 max = array[i];
//             }
//             if (array[i] < min) {
//                 min = array[i];
//             }
//         }
//         Console.WriteLine(max);
//         Console.WriteLine(min);
//         Console.WriteLine(max - min);




//================Решение для автотеста======================================
using System;
using System.Linq;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{ 
    // Разница между максимальным и минимальным элементами массива
 
    // Нахождение минимума массива
    public static double FindMin(double[] numbers)
    {
        //Напишите свое решение здесь
        double min = numbers[0];
         for(int i = 0; i < numbers.Length; i++){ 
            if (numbers[i] < min) {
                min = numbers[i];
            }
        }
        return min;
    }
    
    // Нахождение максимума массива
    public static double FindMax(double[] numbers)
    {
        
        //Напишите свое решение здесь
        double max = numbers[0]; 
        for(int i = 0; i < numbers.Length; i++){ 
            if (numbers[i] > max) {
                max = numbers[i];
            }
         }
         return max;
    }
    
    public static void PrintResult(double[] array)
    {
//Напишите свое решение здесь

        double Result = FindMax(array) - FindMin (array);
        Console.WriteLine(Result);
    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        double[] array;
        

        if (args.Length >= 1) {
            // Объединяем все аргументы командной строки в одну строку
            string joinedArgs = string.Join(" ", args);

            // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
            array = joinedArgs.Split(", ")
                                  .Select(double.Parse)
                                  .ToArray();
            
            // Теперь arr содержит преобразованные в целые числа из командной строки
        
        } else {
           // Если аргументов на входе нет
            array = new double[] {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; // Создание массива
        }
        UserInputToCompileForTest.PrintResult(array);
    }
}