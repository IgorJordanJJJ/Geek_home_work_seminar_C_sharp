/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */
// Вывод чисел по убывания рекурсия
void Recursia(int a)
{
    if(a>1)
    {
        Console.Write($" {a}, ");
        Recursia(a-1);
    }
    else
    {
        Console.Write(" 1 ");
    }
}
//получение числа с консоли, для того, чтобы задать размерность массива
int GetNumberFromConsole(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result>0)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели не число или чило не юольше 0. Введите число больше 0");
        }
    }

    return result;
}
int a = GetNumberFromConsole("Введи число больше 0");
Recursia(a);
