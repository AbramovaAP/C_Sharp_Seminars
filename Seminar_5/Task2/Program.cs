//==================Задание 2=====================
//Задайте двумерный массив. Найдите сумму элементов,
//находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)
//Пример
//   2 3 4 3
//   4 3 4 1 => 2 + 3 + 5 = 10
//   2 9 5 4

// Ввод размеров матрицы
Console.WriteLine("Введите размер m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер n: ");
int n = Convert.ToInt32(Console.ReadLine());

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

// Функция для заполнения матрицы случайными числами
int[,] Generate2dArray(int x, int y)
{
    Random Any = new Random();
    int[,] array = new int[x, y];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Any.Next(0, 10);
        }
    }
    return array;
}

//Функция для подсчета суммы элементов на главной диагонали матрицы
int FindMasterNumbersSum(int[,] array){
    int sum = 0;
    int length = array.GetLength(0);
    if(array.GetLength(0) > array.GetLength(1)){
        length = array.GetLength(1);
    }
    for(int i = 0; i < length; i++){
        sum += array[i, i];
    }
    return sum;
}

int[,] array = Generate2dArray(m, n);
Console.WriteLine();
PrintArr(array);
Console.WriteLine();
Console.WriteLine(FindMasterNumbersSum(array));