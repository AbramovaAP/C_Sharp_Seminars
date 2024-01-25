//=============================Задача 2===================================
//Задайте двумерный массив. 
//Напишите программу, которая поменяет местами первую и последнюю строку массива.
//Начальные условия:
//      int[,] numbers = new int[,] {
//              {1, 2, 3, 4},
//              {5, 6, 7, 8},
//              {9, 10, 11, 12}
//      }; 
//      Выводится:
//              9   10  11  12
//              5   6   7   8
//              1   2   3   4

// //==============================Мое решение РАБОЧЕЕ======================

// // Ввод размеров матрицы
// Console.WriteLine("Введите размер m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите размер n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// //Функция для печати матрицы
// void PrintArr(int[,] arry)
// {
//     for (int i = 0; i < arry.GetLength(0); i++)
//     {
//         for (int j = 0; j < arry.GetLength(1); j++)
//         {
//             Console.Write($"{arry[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// // Функция для заполнения матрицы случайными числами
// int[,] Generate2dArray(int x, int y)
// {
//     Random Any = new Random();
//     int[,] array = new int[x, y];
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Any.Next(0, 10);
//         }
//     }
//     return array;
// }

// //Функция для подсчета суммы элементов на главной диагонали матрицы
// int[,] FindMasterNumbersSum(int[,] MASS){
//     int temp = 0;
//     for(int i = 0; i < MASS.GetLength(0); i++)
//     {
//         for (int j = 0; j < MASS.GetLength(1); j++) {
//             temp = MASS[0,j];
//             MASS[0,j] = MASS[m-1,j];
//             MASS[m-1,j] = temp;
//         }
//     }
//     for(int i = 0; i < MASS.GetLength(0); i++)
//     {
//         for (int j = 0; j < MASS.GetLength(1); j++) {
//             Console.Write($"{MASS[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
//     return MASS;
// }

// int[,] array = Generate2dArray(m, n);
// Console.WriteLine();
// Console.WriteLine("Исходный массив:");
// PrintArr(array);
// Console.WriteLine();
// Console.WriteLine("Новый массив:");
// FindMasterNumbersSum(array);

//====================Решение для автотеста======================
using System;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{  
// Печать массива
    public static void PrintArray(int[,] array)
    {
        //Напишите свое решение здесь
        for(int i = 0; i < array.GetLength(0);i++)
        {
            for( int j=0; j < array.GetLength(1);j++)
            {
                Console.Write($"{array[i,j]}\t");
            }
            Console.WriteLine();
        }
    }

// Обмен первой с последней строкой
    public static int[,] SwapFirstLastRows(int[,] array)
    {
        //Напишите свое решение здесь
       
        for (int j = 0; j < array.GetLength(1); j++) {
            SwapItems (array, j);
        }
        return array;

    }
    

// Обмен элементами массива
    public static void SwapItems(int[,] array, int j)
    {
       //Напишите свое решение здесь
        int temp = array[0,j];
                array[0,j] = array[array.GetLength(0) - 1, j];
                array[array.GetLength(0) - 1, j] = temp;

    }

    public static void PrintResult(int[,] numbers)
    {
        //Напишите свое решение здесь
        PrintArray(SwapFirstLastRows(numbers));
    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        int[,] numbers;

        if (args.Length >= 1)
        {
            // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
            string[] rows = args[0].Split(',');

            int rowCount = rows.Length;
            int colCount = rows[0].Trim().Split(' ').Length;

            numbers = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] rowElements = rows[i].Trim().Split(' ');

                for (int j = 0; j < colCount; j++)
                {
                    if (int.TryParse(rowElements[j], out int result))
                    {
                        numbers[i, j] = result;
                    }
                    else
                    {
                        Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
                        return;
                    }
                }
            }
        }
        else
        {
            // Если аргументов на входе нет, используем примерный массив
            numbers = new int[,]
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            }; 
        }
        UserInputToCompileForTest.PrintResult(numbers);
    }
}