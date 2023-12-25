// -----------------Задача 4.-----------------------
// Напишите программу, которая выводит третью с конца
// цифру заданного числа или сообщает, что третьей цифры
// нет.
// 456 => 4
// 7812 => 8
// 91 => Третьей цифры нет

// // Решение №1 через строку
// Console.Write("Введите число: ");
// string num = Console.ReadLine();
// int num_len = num.Length;
// Console.WriteLine($"Длина введенного числа: {num.Length}");

// if (num_len < 3) {
//     Console.WriteLine("Третий цифры нет!");
// }
// else {
//     int num1 = Convert.ToInt32(Convert.ToString(num[2]));
//     Console.WriteLine($"Третья с начала {num1}");
//     int num2 = Convert.ToInt32(Convert.ToString(num[num_len - 3]));
//     Console.WriteLine($"Третья с конца {num2}");
// }

// Решение №2 через математику

Console.WriteLine("Введите число: ");
string num =Console.ReadLine();
int num_len = num.Length;
int n = Convert.ToInt32(num);
int b;
int a = n / 100;
if (a < 1){
    Console.WriteLine("Третьей цифры нет.");
}
else{
    a = a % 10;
    Console.WriteLine($"{n} => {a}");
    b = n / Convert.ToInt32(Math.Pow(10,(num_len - 3)));
    b = b % 10;
    Console.WriteLine($"{n} => {b}");
}

// // Решение №3
// string s = Console.ReadLine();
// if (s.Length < 3) 
// {
//     Console.WriteLine("No third number.");
//     return;
// }
// int i = Convert.ToInt32(s);
// int thirdFirst = i / (int)Math.Pow(10, s.Length - 3);
// thirdFirst = thirdFirst - thirdFirst / 10 * 10;
// int thirdLast = i / 100;
// thirdLast = thirdLast - thirdLast / 10 * 10;
// Console.WriteLine("For number " + i + " first third number is " 
//                     + thirdFirst + " last third is " + thirdLast);