//========Задача 2==============
// Напишите программу вычисления функции
//Аккермана с помощью рекурсии. Даны два
//неотрицательных числа m и n.  
// Пример:
//          m = 2, n = 3 -> A(m,n) = 9

//                              n + 1, при m = 0;
// Функция Аккермана: A(m,n) =  A(m-1, 1), при m > 0, n = 0;
//                              A[m-1, A(m, n-1)], при m > 0, n > 0;

//============= Решение ==============

int Ackerman(int M, int N)
{
    //Условие 1: A(m,n) = n + 1, при m = 0
    if (M == 0)
    {
        return (N + 1);
    }

    //Условие 2: A(m,n) = A(m-1, 1), при m > 0, n = 0  
    else if (M > 0 && N == 0)
    {
        N = 1;
        return Ackerman(M - 1, N);
    }

    //Условие 3: A(m,n) = A[m-1, A(m, n-1)], при m > 0, n > 0
    else if (M > 0 && N > 0)
    {
        return Ackerman(M - 1, Ackerman(M, N - 1));
    }

    //Рекурсия для выхода из функции
    return Ackerman(M, N);
}

Console.WriteLine("Введите первое (М >= 0!) число M:");
int M = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine("Введите второе (N >= 0!) число N:");
int N = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Функция Аккермана = ");
Console.WriteLine(Ackerman(M, N));
