/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.Write("Write the number No. 1 \n ");
double maxnumber = double.Parse(Console.ReadLine());
double num;
int count =0;
while (count<2)
{
    Console.Write($"Write the number No. {count+2}\n ");
    num = double.Parse(Console.ReadLine());
    if(maxnumber<num)
    {
        maxnumber = num;
    }
    count++;
}
Console.Write($"Max number\t =\t {maxnumber}");