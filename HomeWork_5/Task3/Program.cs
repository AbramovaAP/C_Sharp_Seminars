//==============================Задача 3================================
// Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
// Начальные условия:
//      int[,] numbers = new int[,] {
//           {1, 2, 3},
//           {1, 1, 0},
//           {7, 8, 2},
//           {9, 10, 11}
//      };
//      Выводится: 1

//==============================Мое решение РАБОЧЕЕ======================

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


// //Функция для подсчета суммы элементов по строкам матрицы
// int[] FindMasterNumbersSum(int[,] MASS){
//     int[] Array1  = new int [m]; //одномерный массив
//     int sum = 0;
//     for(int i = 0; i < MASS.GetLength(0); i++)
//     {
//         sum = 0;
//         for (int j = 0; j < MASS.GetLength(1); j++) {
//             sum = sum + MASS[i,j];
//         }
//         Array1[i] = sum;
//         Console.Write($"{Array1[i]}\t");
//     }
//     Console.WriteLine();
    
//     return Array1;
// }

// //Функция для поиска индекса минимального элемента одномерного массива
    
// int MinIndex (int[] Minimum)
// {
//     int min = Minimum[0];
//     int imin = 0;
//     for(int i = 0; i < Minimum.Length; i++)
//     {
//         if (Minimum[i] < min) {
//             min = Minimum[i];
//             imin = i;
//         }
//     }
//     //Console.WriteLine(min);
//     Console.Write(imin);
//     return imin;
// }


// int[,] array = Generate2dArray(m, n);
// Console.WriteLine();

// Console.WriteLine("Исходный двумерный массив:");
// PrintArr2d(array);
// Console.WriteLine();

// Console.WriteLine("Новый одномерный массив:");
// int[] array1 = FindMasterNumbersSum(array);

// Console.WriteLine("Номер строки с минимальным элементом:");
// MinIndex(array1);
// Console.WriteLine();


//====================Решение для автотеста======================

using System;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{
    /// Вычисление сумм по строкам (на выходе массив с суммами строк)
    public static int[] SumRows(int[,] array)
    {
      //Напишите свое решение здесь
      int m = array.GetLength(0);
        int[] Array1  = new int [m]; //одномерный массив пока еще пустой
        int sum = 0;
        for(int i = 0; i < array.GetLength(0); i++)
        {
            sum = 0;
            for (int j = 0; j < array.GetLength(1); j++) {
                sum = sum + array[i,j];
            }
            Array1[i] = sum;
            //Console.Write($"{Array1[i]}\t");
        }
        //Console.WriteLine();
        
        return Array1;
    }
    
    // Получение индекса минимального элемента в одномерном массиве == номеру строки в двумерном массиве
    public static int MinIndex(int[] array)
    {
       //Напишите свое решение здесь
        int min = array[0];
        int imin = 0;
        for(int i = 0; i < array.Length; i++)
            {
                if (array[i] < min) {
                    min = array[i];
                    imin = i;
                }
            }
        Console.Write(imin);
        return imin;
    }
    public static void PrintResult(int[,] numbers)
    {   
       //Напишите свое решение здесь
        // Console.WriteLine("Исходный двумерный массив:");
        // Console.Write(numbers);
        // Console.WriteLine();

        // Console.WriteLine("Новый одномерный массив:");
         int[] array1 = SumRows(numbers);

        //Console.WriteLine("Номер строки с минимальным элементом:");
        MinIndex(array1);
        //Console.WriteLine();
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
            
            numbers = new int[,] {
                {1, 2, 3},
                {1, 1, 0},
                {7, 8, 2},
                {9, 10, 11}
    };      
        }
        UserInputToCompileForTest.PrintResult(numbers);
    }
}