/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/
Console.WriteLine("Write number");
int number = int.Parse(Console.ReadLine());
int number_2=number;
int count=0;
while(number_2 > 0)
{
    number_2 = number_2 / 10;
    count++;
}
if (number/100 == 0)
{
    Console.WriteLine("No third number");
}
else if (count == 3)
{
    Console.WriteLine(number%10);
}
else 
{
    number = number/(int)(Math.Pow(10,(count-3)));
    number = number%10;
    Console.WriteLine(number);
}