// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Pallidrom(int number)
{
    if (number < 10000 && number > 1000000)
    {
        Console.WriteLine("Wrong number");
    }
    else
    {
        int [] array = number.ToString().ToCharArray().Select(Convert.ToInt32).ToArray(); // число в массив
        Array.Reverse(array);

        int result = 0;
        for (int i = 0; i < array.Length; i++)
        {
        result += array[i] * Convert.ToInt32(Math.Pow(10, array.Length-i-1));
        Console.WriteLine(result);
        }
        
    }
return number;
}
Console.WriteLine("Input number ");
int number = Convert.ToInt32(Console.Read());
Pallidrom(number);
Console.WriteLine();







// Задача 21. Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53






// Задача 23. Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125



