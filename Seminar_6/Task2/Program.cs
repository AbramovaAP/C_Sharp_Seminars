//На основе символов строки (тип string) сформировать массив символов (тип char[]).
// Вывести массив на экран.

char[] StringOfChar(string str)
{
    char[] mas = new char[str.Length];

    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = str[i];
//        Console.WriteLine($"{str[i]} -> {mas[i]}");
    }
    return mas;
}

void PrintMas(char[] arr)
{
    foreach (var item in arr)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}


string st = Console.ReadLine()!; //!- не будет предупреждения о пустой строке

PrintMas(StringOfChar(st));

//Проблемы с выводом руссих букв. Пробить кодировку на С# в VSC