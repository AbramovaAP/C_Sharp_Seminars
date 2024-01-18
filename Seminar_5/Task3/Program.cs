//===================Задание 3==========================
//Задайте двумерный массив из целых чисел. Сформируйте новый
//одномерный массив, состоящий из средних арифметических
//значений по строкам двумерного массива.
//Пример
//   2 3 4 3
//   4 3 4 1 => [3 3 5]
//   2 9 5 4

// Ввод размеров матрицы
Console.WriteLine("Введите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
int [,] Array2 = new int [m,n]; //пустой двумерный массив
//Array2 - двумерный массив
//Array1 - одномерный массив

// Функция для заполнения матрицы случайными числами
int[,] RandomArr(int[,] Array2)
{
   for(int i = 0; i < Array2.GetLength(0);i++)
    {
        for( int j=0; j < Array2.GetLength(1);j++)
        {
            Array2[i,j]=new Random().Next(0,10);
        }
    }
    return Array2;
}

//Функция для печати матрицы
void PrintArr (int[,] Array2)
{
 for(int i = 0; i < Array2.GetLength(0);i++)
    {
        for( int j=0; j < Array2.GetLength(1);j++)
        {
           Console.Write($"{Array2[i,j]}\t");
        }
        Console.WriteLine();
    }
}

double[] Array1 = new double[m]; //пустой одномерный массив с плавающей запятой

//Значения матрицы записываем в отдельную переменную и выводим на печать
int[,] Number = RandomArr(Array2);
PrintArr(Number); 
Console.WriteLine();

//Цикл для поиска ср арифметического значения по строкам матрицы
double count=0; //счетчик
for(int i = 0; i < Number.GetLength(0);i++)
    {
        count=0; // после перехода на новую строку, обнуляем счетчик
        for( int j=0; j < Number.GetLength(1);j++)
        {
          count += Number[i,j];
    
        }
       Array1[i]=count / Number.GetLength(1);
    }
 
 //Цикл для печати нового одномерного массива
 foreach (var item in Array1)
 {
    Console.Write($"{item} ");
 }
