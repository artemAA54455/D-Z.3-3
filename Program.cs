
// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// bool IsPallindrome (int num) 
// {
//     if ( num / 10000 == num % 10
//         && (num / 1000) % 10 == (num % 100) / 10
//         ) return true;
//     else return false;

// }
// Console.Write("Please input number N = ");
// int numN = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ($"{numN} -> {IsPallindrome (numN)}");




// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


// double GetDistance (int xA, int yA, int zA, int xB, int yB, int zB )
// {
//     double result = Math.Sqrt((xB - xA) * (xB - xA) + (yB - yA) * (yB - yA) + (zB - zA) * (zB - zA));
//     return Math.Round(result, 2);   
// }
// Console.Write("Please input xA = ");
//  int xA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please input yA = ");
//  int yA = Convert.ToInt32(Console.ReadLine());
//  Console.Write("Please input zA = ");
//  int zA = Convert.ToInt32(Console.ReadLine());

//  Console.Write("Please input xB = ");
//  int xB = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please input yB = ");
//  int yB = Convert.ToInt32(Console.ReadLine());
//  Console.Write("Please input zB = ");
//  int zB = Convert.ToInt32(Console.ReadLine());

//  Console.WriteLine ($"A ({xA}, {yA}, {zA}); B ({xB}, {yB}, {zB}); -> { GetDistance(xA, yA, zA, xB, yB, zB)}");





// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void CubeTable (int num) 
// {   
//     Console.Write($"{num} -> ");
//     for (int i = 1; i <= num; i++)
//     {
//        Console.Write($"{i * i * i}; ");
//     }
// }
// Console.Write("Please input number N = ");
// int numN = Convert.ToInt32(Console.ReadLine());
// CubeTable ( numN);


