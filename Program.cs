
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


//Задача 2.Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

// bool CheckTriangle (int a, int b, int c)
// {
//     if(a+b>c && b+c>a && a+c>b)
//     return true;
//     return false;
// }

// int CheckNumber ()
// {   
//     int x = Convert.ToInt32(Console.ReadLine());
//     if(x<=0) return CheckNumber();
//     else return x;
// }

// Console.WriteLine("Input Lenght A:");
// int a = CheckNumber();
// Console.WriteLine("Input Lenght B:");
// int b = CheckNumber();
// Console.WriteLine("Input Lenght C:");
// int c = CheckNumber();

// Console.WriteLine(CheckTriangle(a,b,c));

//Задача 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.


// int[] Fibonacci(int a, int b, int count) //count - колличество элементов массива
// {
//     int[] array = new int[count];
//     array[0] = a;
//     array[1] = b;
//     for (int i = 2; i < count; i++)
//     {
//         array[i] = array[i - 1] + array[i - 2];
//     }
//     return array;
// }
// ShowArray(Fibonacci(0, 1, 13));


//Напишите цикл, который принимает на вход два числа (A и B),
//возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

/*int FindResult (int A, int B)
{
    int num = A;
    for (int i = 1; i < B; i++)
        {
            num = num * A;
        }
    return num;
}

Console.WriteLine ("Input number A");
int A = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input number B");
int B = Convert.ToInt32 (Console.ReadLine());
int result = FindResult (A, B);
Console.WriteLine ($"Число {A} в степени {B} -> {result}");*/

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

/*int FindSum (int a)
{
    int sum = 0;
    {
        while (a > 0)
            {
                sum = sum + (a % 10);
                a = a / 10;
            }
    }
    return sum;
}

Console.WriteLine ("Input number");
int number = Convert.ToInt32 (Console.ReadLine());
int result = FindSum (number);
Console.WriteLine ($"{number} -> {result}");*/


//Напишите цикл, который принимает на вход два числа (A и B),
//возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

// int FindResult (int A, int B)
// {
//     int num = A;
//     for (int i = 1; i < B; i++)
//         {
//             num = num * A;
//         }
//     return num;
// }

// Console.WriteLine ("Input number A");
// int A = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine ("Input number B");
// int B = Convert.ToInt32 (Console.ReadLine());
// int result = FindResult (A, B);
// Console.WriteLine ($"Число {A} в степени {B} -> {result}");


//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

// int FindSum (int a)
// {
//     int sum = 0;
//     {
//         while (a > 0)
//             {
//                 sum = sum + (a % 10);
//                 a = a / 10;
//             }
//     }
//     return sum;
// }

// Console.WriteLine ("Input number");
// int number = Convert.ToInt32 (Console.ReadLine());
// int result = FindSum (number);
// Console.WriteLine ($"{number} -> {result}");


//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

// int[] GreatRandomArray (int size, int min, int max)
// {
//     int [] newArray = new int [8];
//     for (int i = 0; i < 8; i++)
//         {
//         newArray[i] = new Random().Next(min, max + 1);
//         }
//     return newArray;
// }

// void ShowArray (int[] array)
// {
//     Console.Write ("Массив -> ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write (array[i] + " ");
//     }
// }

// Console.WriteLine("Введите минимум");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимум");
// int max = Convert.ToInt32(Console.ReadLine());
// int [] MyArray = GreatRandomArray (8, min, max);
// ShowArray (MyArray);