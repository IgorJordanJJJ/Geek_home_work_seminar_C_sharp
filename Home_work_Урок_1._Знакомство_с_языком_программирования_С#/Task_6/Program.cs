﻿/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/

Console.Write("Write a number\n");
double num = double.Parse(Console.ReadLine());
if (num%2 == 1)
{
    Console.Write("No");
}
else
{
    Console.Write("Yes");
}