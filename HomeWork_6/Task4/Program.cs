// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. 
//Сформировать строку, в которой слова расположены в обратном порядке. 
//В полученной строке слова должны быть также разделены пробелами.

void Obmen(string st)
{

//Новый нулевой массив
string[] mass = st.Split(" ");// если запись в скобках указать, как (", "), 
                            //при этом в начальной строке будет "ZZ xx ZZ, tT1 123",
                            // то вывод будет:
                            //              ZZ xx ZZ
                            //              tT1 123

Console.WriteLine($"Исходная строка:");
foreach (var item in mass)
{
    Console.Write($"{item} ");
}

//Меняем элементы местами
string temp;

for (int i = 0; i < mass.Length/2; i++){
    temp = mass[i];
    mass[i] = mass[mass.Length - 1 - i];
    mass[mass.Length - 1 - i] = temp;
}
Console.WriteLine();

//Перевернутый массив:
 Console.WriteLine("\nПеревернутая строка: ");

string[] NewMass = new string[mass.Length];
//Вывод перевернутого массива
for (int i = 0; i < mass.Length; i++){
        NewMass[i] = mass[i];
        Console.Write($"{NewMass[i]} ");
}
////Вывод можно записать таким образом
// foreach (var item in mass)
// {
//     Console.Write($"{item} ");
// }
}

//Задаем строку символов:
string stroka = "ZZ xx ZZ tT1 123";
//Запускаем функцию:
Obmen(stroka);

