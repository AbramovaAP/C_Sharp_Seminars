//=============================Задача 1===================================
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
///и возвращает значение этого элемента или же указание, 
//что такого элемента нет: "Позиция по рядам выходит за пределы массива"
// или "Позиция по колонкам выходит за пределы массива"
// Позиции в массиве считать от единицы.
// В коде, начальные условия:
//          int[,] numbers = new int[,] {
//          {1, 2, 3, 4},
//          {5, 6, 7, 8},
//          {9, 10, 11, 12}
//          };
// int x = 2;
// int y = 2;
// Выводится: 6

// //====================================Мое решение РАБОЧЕЕ=============================
// // Ввод размеров матрицы
// Console.WriteLine("Введите количество строк m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// //Функция для печати матрицы
// void PrintArr2d(int[,] arry)
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



// //Позиции в массиве считать от единицы.
// int x = 5;
// int y = 2;
// //Функция для определения вхождения в массив:
// int Massiv_ON_Element (int[,] array){
    
//     //Вывод на консоль позиций по строке и столбцу:
//     Console.WriteLine($"Позиция по строке х = {x};");
//     Console.WriteLine($"Позиция по столбцу у = {y};");
//     x = x - 1;
//     y = y - 1;

//     int num = 0; // элемент из массива
//     if (x < array.GetLength(0) && y < array.GetLength(1)){
//          num = array[x,y];
//         Console.WriteLine($"Элемент двумерного массива с индексами array[{x},{y}] = {num};");
//     }

//     else if (x > array.GetLength(0)) {
//         Console.WriteLine($"Позиция по рядам выходит за пределы массива");
//     }

//     else if (y > array.GetLength(1)) {
//         Console.WriteLine($"Позиция по колонкам выходит за пределы массива");
//     }
//     return num;
// }

// int[,] array = Generate2dArray(m, n);
// Console.WriteLine();

// Console.WriteLine("Исходный двумерный массив:");
// PrintArr2d(array);
// Console.WriteLine();

// Console.WriteLine("Вхождение в массив");
// Console.WriteLine();

// Massiv_ON_Element(array);
// Console.WriteLine();


//======================================Решение для автотеста==================================
using System;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{ 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Поиск элемента по позициям. Позиции в массиве считать от единицы.
    public static int FindElementByPosition(int[,] array, int x, int y)
    {
        //Напишите свое решение здесь
        x = x - 1;
        y = y - 1;
        int NUM = 0;
        if (x < array.GetLength(0) && y < array.GetLength(1)) {
            NUM = array[x,y];
            Console.WriteLine(NUM);
        }
        return NUM;
    }

// Проверка позиций на вхождение в массив
    public static bool ValidatePosition(int[,] array, int x, int y)
    {
        if ( x > array.GetLength(0) || y > array.GetLength(1))
             {return false;}
        else {return true;}
    }


    public static void PrintResult(int[,] numbers, int x, int y)
    {
        //Напишите свое решение здесь
        
        FindElementByPosition(numbers, x, y); // запускаем ф-ию с новыми переменными

        if (x > numbers.GetLength(0)) {
            Console.WriteLine($"Позиция по рядам выходит за пределы массива");
        }

        if (y > numbers.GetLength(1)) {
            Console.WriteLine($"Позиция по колонкам выходит за пределы массива");
        }
    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {   
        int[,] array;

        int x, y;

        if (args.Length >= 3)
        {
            // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
            string[] rows = args[0].Split(',');

            int rowCount = rows.Length;
            int colCount = rows[0].Trim().Split(' ').Length;

            array = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] rowElements = rows[i].Trim().Split(' ');

                for (int j = 0; j < colCount; j++)
                {
                    if (int.TryParse(rowElements[j], out int result))
                    {
                        array[i, j] = result;
                    }
                    else
                    {
                        Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
                        return;
                    }
                }
            }

            // Парсинг x и y из аргументов
            if (int.TryParse(args[1], out x) && int.TryParse(args[2], out y))
            {
                // Теперь у вас есть двумерный массив "array" и координаты x и y
                UserInputToCompileForTest.PrintResult(array, x, y);
            }
            else
            {
                Console.WriteLine("Error parsing x or y to an integer.");
            }
        }
        else
        {
           
            // Если аргументов на входе нет, используем примерный массив
            array = new int[,]
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            };
            x = 2;
            y = 10;
            
            UserInputToCompileForTest.PrintResult(array, x, y);

        }                
    }
}


