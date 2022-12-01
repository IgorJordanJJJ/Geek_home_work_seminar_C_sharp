/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }
    
    return result;
}

int Pownumber(int a,int b)
{
    int pownum = 1;
    for (int i = 0; i < b; i++)
    {
        pownum = pownum *a;
    }
    return pownum;
}
int A = GetNumber("Введите число A");
int B = GetNumber("Введите число B");
int powresult = Pownumber(A,B);
Console.WriteLine($"Число {A} в степени {B} = {powresult}");