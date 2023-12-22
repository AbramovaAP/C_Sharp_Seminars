// ---------------Условие задачи №4-----------------------
    // Вывести четные числа

    // Внутри класса Answer напишите метод PrintEvenNumbers, 
    // которая на вход принимает число (number),
    // а на выходе выводит все чётные числа 
    // от 1 до number (включительно), разделеные знаком табуляции.

    // Пример:
    // number = 5 -> 2    4
    // number = 8 -> 2    4    6    8

// ---------------Решение задачи №4-----------------------

using System;

public class Answer {
    static void PrintEvenNumbers(int number)
    {
      // Введите свое решение ниже
      // int counter = 1;

      //   if (counter % 2 == 0) {
      //     if (counter <= number) {
      //       Console.Write($"{counter}\t");}
      //       counter = counter + 1;}
      //   }
      //   else {counter = counter + 1;}
    
      int counter = 1;

      while (counter <= number){
        if (counter % 2 == 0) 
        {
            Console.Write($"{counter}\t");
            counter = counter + 1;
        }
         else {counter = counter + 1;}
      }
    

    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 6;
        }

        // Не удаляйте строки ниже
        PrintEvenNumbers(number);
    }
}