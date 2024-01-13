  // //=======================Варианты создания массива=================================
// Console.WriteLine ("Введите размер массива: ");
// int n = Convert.ToInt32(Console.ReadLine()); //Переводим введенную строку в тип int
// int [] mas = new int[n];

                    // //FUNCTION
                    // void Print_mas(int[] col){
                    //     foreach(var item in col){
                    //     Console.Write($"{item}\t");
                    //     }
                    // Console.WriteLine ();
                    // }
                    // Print_mas(mas);


                    // //WHILE
                    // int ind = 0;
                    // while (ind < mas.Length) {
                    //     Console.Write($"{mas[ind]}\t");
                    //     ind++;
                    // }
                    // Console.WriteLine();

                    // //FOR
                    // for(int i = 0; i < mas.Length; i++){
                    //     Console.Write($"{mas[i]}\t");
                    // }
                    // Console.WriteLine();

                    // //FOREACH
                    // foreach(var item in mas){
                    //     Console.Write($"{item}\t");
                    // }

            //=================Задача 1=======================
//Написать программу, которая определяет присутствует ли заданное число в массиве.
//Программа должна выдавать ответ: Да/ Нет.
//Н-р,  [1,3,4,19,3]:8 => Нет;
//      [-4,3,4,1]:3 => Да;

// void Print_mas(int[] col){
//     foreach(var item in col){
//     Console.Write($"{item}\t");
//     }
// Console.WriteLine ();
// }

// int[] Random_mas (int[] col){
//     for(int i = 0; i < col.Length; i++){
//         col[i] = new Random().Next(1,10);
//     }
//     return col;
// }
// int[] new_mas = Random_mas(mas);
// Print_mas(new_mas);

// Console.WriteLine ("Введите искомое число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// foreach(var item in new_mas){
//     if (item == num)
//     count++;
// }
// if(count != 0){
//     Console.Write("Да");
// }
// else{
//     Console.Write("Нет");
// }

//Мое решение без фуннкций:
// int[] a = new int[] {1,3,4,19,8};
// int num = 8;
// for(int i = 0; i < a.Length; i++){
//     if(a[i] == num){
//     Console.WriteLine("Да");
//     }
// else if (i == a.Length-1){
//     Console.WriteLine("Нет");
//     }
// }


            //=================Задача 2=======================
//Задать массив из 10 элементов, заполненный числами из промежутка [-10, 10].
//Заменить отрицательные элементы на положительные и наоборот.

//Мое решение:
//Random rand = new Random();
// int[] arr = new int[10];
// for(int i = 0; i < arr.Length; i++){
//     arr[i] = rand.Next(-10,11);
//     Console.Write(arr[i] + " ");
//     Console.Write($"{arr[i] * (-1)}\t");
// }

//Решение преподавателя и студента:
// int[] arr = {-10,-9,-8,-7,7,8,9,10};
// for(int i = 0; i < arr.Length; i++){
//     if(arr[i] <= 0){
//       arr[i] = arr[i] * (-1);
//       Console.WriteLine(arr[i]);
//     }
// else {
//       arr[i] = arr[i] * (-1);
//       Console.WriteLine(arr[i]);
//     }
// }

            //=================Задача 3=======================
//Найти произведение пар чисел, в одномерном массиве.
//Парой считается первый и последний элементы, второй и последний и т.д.
//Результат записать в новый массив.
//Н-р,  [1,3,2,4,2,3] => [3,6,8];
//      [2,3,1,7,5,6,3] => [6,18,5] (элемент 7 не имеет пары);

//Задаем рандомный размер массива
// int n = new Random().Next(5,10);
// int[] arr = new int[n];
// //Создаем рандомный массив
// int[] randomarray (int[] c){
//     for(int i = 0; i < c.Length; i++){
//     c[i] = new Random().Next(1,100);
//     }
//     return c;
// }
// arr = randomarray (arr);
// //Введем получившийсяя массив, для наглядности
// for(int i = 0; i < arr.Length; i++){
//     Console.Write($"{arr[i]} ");
// }
// Console.WriteLine(); // пробел между строками
// //Запишем реализацию задачи
// int a = 0;
// int[] new_arr = new int[arr.Length/2]; //задали новый массив
// for(int i = 0; i < arr.Length/2; i++){
//     a = arr[i] * arr[(arr.Length - 1) - i];
//     //Console.Write($"{a} "); //для проверки
//     new_arr[i] = a;
// }
// //Выведем новый массив
// for(int i = 0; i < new_arr.Length; i++){
//     Console.Write($"{new_arr[i]} ");
// }
// Console.WriteLine(); // пробел между строками
// //Если размер основного массива нечетный, то
// if(arr.Length % 2 == 1){
//     Console.WriteLine($"Элемент {arr[arr.Length/2]} не имеет пары");
// }
            //=================Задача 4=======================
//Дано натуральное трехзначное число. Создаем массив, состоящий из цифр этого числа.
//Младший разряд должен располагаться на 0-м индексе массива, старший на 2-м.
//Н-р,  456 => [6 5 4];
//      781 => [1 8 7];

int num = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[3];
for (int i = 0; i < arr.Length; i++){
    arr[i] = num % 10;
    num = num / 10;
    Console. Write ($"{arr[i]} ");
}