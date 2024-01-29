//========Задача 3==============
// Задайте произвольный массив. Выведете
//его элементы, начиная с конца. Использовать
//рекурсию, не использовать циклы.

// Пример:
//          [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

//============= Решение ==============

int Revers(int[] a, int i = 0)
{
    int n = a.Length;
    if (i < n)
    {
        Console.Write($"{a[n - 1 - i]} ");
        i++; 
    }
    else
    {return 0;}
    return Revers(a, i);
}

int n = 5;
Random rand = new Random();
int[] a = new int[n];

Console.WriteLine("исходный массив:");
for (int j = 0; j < n; j++)
{
    a[j] = rand.Next(-5, 11);
    Console.Write($"{a[j]} ");
}


int i = 0;
Console.WriteLine();
Console.WriteLine("перевернутый массив:");
Revers(a, i);
//=========================================================================
