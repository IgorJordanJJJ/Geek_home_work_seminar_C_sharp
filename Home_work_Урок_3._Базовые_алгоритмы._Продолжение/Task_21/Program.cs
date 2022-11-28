/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

//функция получения числа с консоли
int GetNumber(string message)
{
    int result = 0;
    bool isCorrect = false;


    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) )
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели не число или 0. Введите корректное число");
        }
    }

    return result;
}


int xa = GetNumber("Введите координату Х1:");
int ya = GetNumber("Введите координату У1:");
int za = GetNumber("Введите координату Z1:");


int xb = GetNumber("Введите координату Х2:");
int yb = GetNumber("Введите координату У2:");
int zb = GetNumber("Введите координату Z2:");



double lenpoint = Math.Sqrt(Math.Pow((xb-xa),2)+Math.Pow((yb-ya),2)+Math.Pow((zb-za),2));
//Console.WriteLine(lenpoint.ToString("0.00"));
Console.WriteLine("{0:f2}",lenpoint);

