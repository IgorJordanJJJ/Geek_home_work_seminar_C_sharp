/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/
int number = 10;
while(number < 1 || number > 7)
{
    Console.WriteLine("Write a number from 1 to 7");
    number = int.Parse(Console.ReadLine());
    if (number >= 1 && number <= 7)
    {
        if(number>5)
        {
            Console.WriteLine("Yes");    
        }
         else
        {
            Console.WriteLine("No");
        }
    }
}
