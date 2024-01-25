//==========Задача 1==========
//Задайте двумерный массив символов (тип char [,]). 
//Создать строку из символов этого массива.

// Ввод размеров матрицы
Console.WriteLine("Введите количество строк x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов y: ");
int y = Convert.ToInt32(Console.ReadLine());

//Функция для печати матрицы
void PrintArr2d(char[,] arry)
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

// Функция для заполнения матрицы случайными числами
char[,] Generate2dArray(int x, int y)
{
    Random Any = new Random();
    char[,] array = new char[x, y];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToChar(Any.Next('a', 'z'));
        }
    }
    return array;
}

//Запуск функции для генерации массива случайных символов
char[,] array = Generate2dArray(x, y);
Console.WriteLine();

//Запуск функции для вывода массива
Console.WriteLine("Исходный двумерный массив:");
PrintArr2d(array);
Console.WriteLine();

//Цикл для создания строки из символов рандомного массива:
foreach (var item in array) {
    Console.Write($"{item}   ");
}

