/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */


//получение числа с консоли, для того, чтобы задать размерность массива
int GetFirstNumberFromConsole(string message)
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
            Console.WriteLine("Ввели не верные данные. Введите число больше M, которое больше 0");
        }
    }

    return result;
}
int GetSecondNumberFromConsole(string message,int b)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result>0 && result>b)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели не верные данные. Введите число больше N, которое больше 0 и больше числа M");
        }
    }

    return result;
}
int Recursia(int a,int b)
{
    if(b<a)
    {
        
        return 0;
    }
    else
    {
        return a+Recursia(a+1,b);
    }
}

int M = GetFirstNumberFromConsole("Введите число больше M, которое больше 0");
int N = GetSecondNumberFromConsole("Введите число больше N, которое больше 0 и больше числа M",M);
int sum = Recursia(M,N);
Console.WriteLine($"Сумма чисел {sum}");