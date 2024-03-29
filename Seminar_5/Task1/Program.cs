﻿//=================Задание 1=====================
//Задайте двумерный массив. Найдите элементы, у которых оба
//индекса чётные, и замените эти элементы на их квадраты. Оформить этапы в виде функций
//Пример:
//   2 3 4 3          4 3 4 3
//   4 3 4 1 =>       4 3 4 1
//   2 9 5 4          2 9 25 4

// Ввод размероа матрицы
Console.WriteLine("Введите размер m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер n: ");
int n = Convert.ToInt32(Console.ReadLine());

// Цикл для заполнения матрицы случайными числами
int[,] arr = new int[m, n];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(1, 10);
    }
}

//Функция для печати матрицы
void PrintArr(int[,] arry)
{
    for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arry.GetLength(1); j++)
        {
            Console.Write($"{arry[i, j]}\t");
        }
        Console.WriteLine();
    }
}

//Функция для определения четности индексов и возведение элементов в квадрат
int[,] Sqrt(int[,] arry)
{
    for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arry.GetLength(1); j++)
        {
            if(i % 2 == 0 && j % 2 == 0)
            {
                arry[i,j] = arry[i,j] * arry[i,j];
            }
        }
    }
    return arry;
}

//Запускаем функцию PrintArr для печати исходной матрицы и измененной
PrintArr(arr); //исходная матрица
int[,] newArr = Sqrt(arr); //измененную матрицу сохраняем в новую переменную
Console.WriteLine(); //пробел
PrintArr(newArr); //измененная матрица