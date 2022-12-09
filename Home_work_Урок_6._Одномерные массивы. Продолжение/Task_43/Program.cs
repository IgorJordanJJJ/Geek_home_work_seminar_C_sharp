/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

//получение координаты x
/* 
y = k1 * x + b1
y = k2 * x + b2
k1 * x + b1 = k2 * x + b2
x = (b2-b1)/(k1-k2)
  */
double Get_X(double k1,double k2,double b1,double b2)
{
    double x =0;
    x=(b2-b1)/(k1-k2);
    return x;
}
//получение координаты y
double Get_Y(double k1,double x,double b1)
{
    double y=0;
    y= x*k1+b1;
    return y;
}
//получение числа с консоли, для того, чтобы задать размерность массива
double GetNumberFromConsole(string message)
{
    bool isCorrect = false;
    double result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(double.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели не число. Введите число");
        }
    }

    return result;
}

double k1 = GetNumberFromConsole("Введите k1");
double b1 = GetNumberFromConsole("Введите b1");
double k2 = GetNumberFromConsole("Введите k2");
double b2 = GetNumberFromConsole("Введите b2");
double x = Get_X(k1,k2,b1,b2);
double y = Get_Y(k1,x,b1);
Console.WriteLine($"Точка пересечения двух прямых = ({x}; {y})");
