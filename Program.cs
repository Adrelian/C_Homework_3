﻿// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// void Pallidrom(int number)
// {
//     if (number < 10000 && number > 1000000)
//     {
//         Console.WriteLine("Wrong number");
//     }
//     else
//     {
//         int [] array = new int[5];
//         for (int i =0; i < 5; i++)
//         {
//             array[i] = 
//         }
//     }
// }
// Console.WriteLine("Input number ");
// int number = Convert.ToInt32(Console.Read());
// Pallidrom(number);

var digits = new List<int>();
var integer = 123456;
while (integer > 0)
{
  digits.Add(integer % 10);
  integer /= 10;
}

Console.WriteLine(digits());






// Задача 21. Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53






// Задача 23. Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125



