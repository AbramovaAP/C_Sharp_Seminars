// Задача 3: Задайте произвольную строку. 
//Выясните, является ли она палиндромом.

//1. Создаем произвольную строку:
Console.WriteLine("ВВведите строку:");
string st = Console.ReadLine()!;

//2. Преобразуем входную строку в тип char[]:
char[] OneMassiv = st.ToCharArray();

//3. Функция для проверки на палиндром:
bool Palindrom (char[] NewMass)
{
    for (int i = 0; i < NewMass.Length / 2; i++) 
        if (NewMass[i] != NewMass[NewMass.Length - 1 - i])
    return false;
    return true;
    
}

//4. Вызываем функцию Palindrom для вывода результата:
if(Palindrom (OneMassiv)){
    Console.WriteLine($"Исходный массив: {OneMassiv} - является палиндромом!");
}
else {Console.WriteLine($"Исходный массив: {OneMassiv} - НЕ является палиндромом!");}

//====================Работает====================================================================================================
// //3. Функция для переворота массива и преобразование string в char:

// void Main(char[] numbers)
// {
//         //int[] numbers = { 1, 3, 5, 6, 7, 8 }; // Исходный массив
//         char temp;
//         // Вывод исходного массива
//         Console.Write("Исходный массив: ");

//         char[] Ishod = new char[numbers.Length];
//         for (int i = 0; i < numbers.Length; i++){
//         Ishod[i] = numbers[i];
//         Console.Write($"{Ishod[i]} ");
//         }
//         // foreach (int Ishod in numbers)
//         // {
//         //     Console.Write(Ishod + " ");
//         // }

//         // Реверсирование массива
//         for (int i = 0; i < numbers.Length / 2; i++)
//         {
//             // Меняем местами элементы
//             temp = numbers[i];
//             numbers[i] = numbers[numbers.Length - 1 - i];
//             numbers[numbers.Length - 1 - i] = temp;
//         }
//         // // Вывод измененного массива
//         // Console.Write("\nПеревернутый массив: ");
//         // foreach (int number in numbers)
//         // {
//         //     Console.Write(number + " ");
//         // }

//         Console.Write("\nПеревернутый массив: ");

//         char[] NewMass = new char[numbers.Length];
//         //Вывод перевернутого массива
//         for (int i = 0; i < numbers.Length; i++){
//             NewMass[i] = numbers[i];
//             Console.Write($"{NewMass[i]} ");
//         }


//         Console.WriteLine();
//         //Проверка на полиндром:

// }

// //1. Создаем произвольную строку:
// string st = Console.ReadLine()!;
// //2. Преобразуем входную строку в тип int:
// char[] OneMassiv = st.ToCharArray();

// //4. Запускаем функцию:
// Main(OneMassiv);


//====================Работает====================================================================================================
// using System;
// class Program
// {
//     static void Main()
//     {

//         int[] numbers = { 1, 3, 5, 6, 7, 8 }; // Исходный массив
//         int temp;
//         // Вывод исходного массива
//         Console.Write("Исходный массив: ");
//         foreach (int number in numbers)
//         {
//             Console.Write(number + " ");
//         }
//         // Реверсирование массива
//         for (int i = 0; i < numbers.Length / 2; i++)
//         {
//             // Меняем местами элементы
//             temp = numbers[i];
//             numbers[i] = numbers[numbers.Length - 1 - i];
//             numbers[numbers.Length - 1 - i] = temp;
//         }
//         // Вывод измененного массива
//         Console.Write("\nПеревернутый массив: ");
//         foreach (int number in numbers)
//         {
//             Console.Write(number + " ");
//         }
//     }
// }