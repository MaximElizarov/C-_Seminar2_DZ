﻿Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int r = 0;
if (n >= 99)
{
    while (n > 999)
    {
        n = n / 10;
    }
     r = n % 10;
     Console.Write(r);
}

else 
    Console.Write("Третьей цифры нет");

// Задача 13: Напишите программу, которая выводит третью цифру(c начала) заданного числа или сообщает, что третьей цифры нет.
// НЕ ИСПОЛЬЗОВАТЬ НУМЕРАЦИЮ СТРОК
// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
