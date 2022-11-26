// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// void FindPolindrom (int number)
// {
//     if (number == 0) Console.WriteLine("0 это палиндром");// 0 это полиндром
//     else
//     {    
//         // Проверка чиcла пользователя, отбросить отрицательные и те что деляться на 10 без остатка
//         if (number % 10 != 0 && number > 0)
//         {
//             int newNumber = 0; // Новое число в обратном порядке
//             int preNumber = number; // Новая переменная для хранения остатков от действий
//             while ( number > newNumber ) // пока не дошли до середине делаем
//             {
//                 int rightNum = number % 10; // берём самое правое число от начального значения ( 12345 % 10 -> 5)
//                 preNumber = number; // записываем оставшееся число после одного цикла  (1234)
//                 number = number / 10; // отбираем последнюю цифру от нашего числа ( 12345/10 -> 1234 ) 
//                 newNumber = newNumber * 10 + rightNum; // умножая на 10 увеличиваем разряд и прибавляем новое цисло
//             }
//             // 1. Если обратное число совпало со старым (нечетные разряды)
//             // 2. Если остаток от деления (preNumber) равен новому числу (четные разпяды)
//             if(number == newNumber || preNumber == newNumber) 
//             {
//                 Console.WriteLine("Ваше число полиндром");
//             }
//             else Console.WriteLine("Ваше число НЕ полиндром");
//         }
//         else Console.WriteLine("Ваше число нельзя проверить");
//     }

// }

// Console.Write("Введите ваше число: "); 
// int number = Convert.ToInt32(Console.ReadLine());
// FindPolindrom(number);



// Задача 21. Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// void FindLenghtLine() 

// {
//     Console.WriteLine("Введите координаты первой точки");
//     int x1 = Convert.ToInt32(Console.ReadLine());
//     int y1 = Convert.ToInt32(Console.ReadLine());
//     int z1 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите координаты второй точки");
//     int x2 = Convert.ToInt32(Console.ReadLine());
//     int y2 = Convert.ToInt32(Console.ReadLine());
//     int z2 = Convert.ToInt32(Console.ReadLine());
//     Console.Clear();
//     Console.WriteLine($"Координата точки 1: x1 = {x1} y1 = {y1} z1 = {z1} \nКоордината точки 2: x2 = {x2} y2 = {y2} z2 = {z2}");
//     Console.WriteLine($"Длинная отрезка -> {(double)Math.Round(Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2)),2)}");
// }

// FindLenghtLine();


// Задача 23. Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void findCubeNumber()
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    for(int i = 1; i <= number; i++)
    {
        double result = Math.Pow(i, 3);
        Console.WriteLine($"{i}^{3} = {result}");
    }
}
findCubeNumber();


