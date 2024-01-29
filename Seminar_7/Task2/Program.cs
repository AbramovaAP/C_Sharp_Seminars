//========Задача 2==============
// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// Указание: 
//          Использовать рекурсию. Не использовать цикл.
//Пример:
//      N=5 => 1 2 3 4 5

// //=============Решение 1==============

// string Len(int start, int stop)
// {
//     //Условие выхода из функции:
//     if (start == stop) {return Convert.ToString (start);}

//     //Услговие рекурсии
//     return start + " " + Len(start + 1, stop);
// }


// Console.WriteLine("Введите число:");
// int n = Convert.ToInt32(Console.ReadLine()!);
// Console.WriteLine(Len(1,n));

// //=============Решение 2==============

// string Len(int stop, int start)
// {
//     //Условие выхода из функции:
//     if (start == stop) {return Convert.ToString (start);}

//     //Услговие рекурсии
//     return start + " " + Len(stop, start + 1);
// }


// Console.WriteLine("Введите число:");
// int n = Convert.ToInt32(Console.ReadLine()!);
// Console.WriteLine(Len(n));

//=============Решение 3==============

void Len(int num)
{
    //Условие выхода из функции:
    if (num == 0) {return;}

    //Услговие рекурсии
    Len(num - 1);
    Console.Write($"{num} ");
    //если записать:
    // Console.Write($"{num} ");
    // Len(num - 1); // то вывод чисел будет в обратном порядке
}


Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine()!);
Len(n);