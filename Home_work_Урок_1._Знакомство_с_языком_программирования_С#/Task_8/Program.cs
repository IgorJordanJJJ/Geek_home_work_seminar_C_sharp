/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.Write("Write a number\n");
int len = int.Parse(Console.ReadLine());
int num = 1;
if(len>0)
{
    while( num <= len)
    {
        if (num%2 == 0)
        {
        Console.Write($"{num} \t");
        }
        num++;
    }
}
else if (len ==0 )
{
    Console.Write(0);
}
else 
{
    Console.Write("Dangerous");
}