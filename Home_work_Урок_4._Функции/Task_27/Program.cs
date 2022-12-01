/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/
string GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;
    string test = "";

    while(!isCorrect)
    {
        Console.WriteLine(message);
        test = Console.ReadLine();
        if(int.TryParse(test, out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }
    
    return test;
}

int NumOfNum (string a)
{
    int num = 0;
    int b = int.Parse(a);
    for (int i = 1; i <= a.Length; i++)
    {
        num = num + b%10;
        b = b/10;
    }

    return num;
}

string a = GetNumber("Введите число");
Console.WriteLine($"Сумму цифр в числе {a} = {NumOfNum(a)}");
