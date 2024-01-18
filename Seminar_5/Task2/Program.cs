//==================Задание 2=====================
//Задайте двумерный массив. Найдите сумму элементов,
//находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)
//Пример
//   2 3 4 3
//   4 3 4 1 => 2 + 3 + 5 = 10
//   2 9 5 4

Console.WriteLine("Введите размер m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер n: ");
int n = Convert.ToInt32(Console.ReadLine());

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

