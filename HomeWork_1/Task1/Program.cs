﻿//---------Условие задачи №1---------------------------------
    // Внутри класса Answer напишите метод CompareNumbers, 
    // который на вход принимает два числа и выводит, 
    // какое число большее, а какое меньшее.

    // Пример использования:
    //     На входе:
    // firstNumber: '5'
    // secondNumber: '6'
    //     На выходе:
    // Первое число `5` меньше чем второе число `6`

    //     На входе:
    // firstNumber: '3'
    // secondNumber: '6'
    //     На выходе:
    // Первое число `3` меньше чем второе число `6`

    //     На входе:
    // firstNumber: '3'
    // secondNumber: '3'
    //     На выходе:
    // Введенные числа равны `3`

//---------Решение задачи №1---------------------------------

using System;

public class Answer {
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
        // Введите свое решение ниже
        if (firstNumber > secondNumber) {
            Console.WriteLine($"Первое число `{firstNumber}` больше чем второе число `{secondNumber}`");
        }
        
        else if (firstNumber < secondNumber) {
        Console.WriteLine($"Первое число `{firstNumber}` меньше чем второе число `{secondNumber}`");
        }

        else {Console.WriteLine($"Введенные числа равны `{firstNumber}`");}

    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int firstNumber, secondNumber;

        if (args.Length >= 2) {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            firstNumber = 3;
            secondNumber = -5;
        }

        // Не удаляйте строки ниже
        CompareNumbers(firstNumber, secondNumber);
    }
}