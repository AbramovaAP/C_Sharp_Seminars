//========Задача 1==============
// Задайте значения M и N. Напишите
//программу, которая выведет все натуральные числа
//в промежутке от M до N. Использовать рекурсию, не
//использовать циклы. (M < N)!

// Пример:
//          M = 1; N = 5 -> "1, 2, 3, 4, 5"
//          M = 4; N = 8 -> "4, 5, 6, 7, 8"

//============= Решение ==============

string Len(int start, int stop)
{
    //Условия выхода из функции:
    if (start <= 0) 
    {
        Console.WriteLine ($"Введено НЕнатуральное число.");
        return Convert.ToString (false);
    }

    if (start == stop) {return Convert.ToString (start);}

    if (start > stop) 
    {
        Console.WriteLine ($"Ошибка: {start} !< {stop}. Введите числа, удовлетворяющие условию M < N.");
        return Convert.ToString (false);
    }
    
    //Условие рекурсии
    return start + ", " + Len(start + 1, stop);

}

Console.WriteLine("Введите число M:");
int M = Convert.ToInt32(Console.ReadLine()!); // M -> start

Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine()!); // N -> stop

Console.WriteLine(Len(M,N));