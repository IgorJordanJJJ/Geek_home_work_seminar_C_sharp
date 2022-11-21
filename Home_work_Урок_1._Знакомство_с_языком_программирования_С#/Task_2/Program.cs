/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

double num = double.Parse(Console.ReadLine());
double num_2 = double.Parse(Console.ReadLine());
if (num>num_2)
{
    Console.Write($"Max number\t =\t {num} \n Min number\t =\t {num_2}");
}
else 
{
    Console.Write($"Max number\t =\t {num_2} \n Min number\t =\t {num}");
}
