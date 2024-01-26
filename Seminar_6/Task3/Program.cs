//Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных (aoueiy).
// Пример
// “hello” => 2
// “world” => 1

//1.
void Count(string str)
{
    string vowes = "aoueiy";
    int count = 0;

    foreach (var vo in vowes)
    {
        foreach (var s in str)
        {
            if (vo == s) count++;
        }
    }
    Console.WriteLine(count);
}


string st = Console.ReadLine()!; //!- не будет предупреждения о пустой строке

Count(st);


// //2.
// void Count(string str)
// {
//     string vowes = "aeiouy";
//     int counter = 0;
//     foreach (var Letter in str)
//     {
//         if (vowes.Contains(Letter))
//         {
//             counter++;
//         }
//     }
//     Console.WriteLine(counter);
// }
// string st = Console.ReadLine();
// Count(st);

