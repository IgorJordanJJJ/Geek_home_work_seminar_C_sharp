/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/
//функция получения пятизначного числа с консоли 
string GetNumber(string message)
{
    bool isCorrect = false;
    string result = "";

    while(!isCorrect)
    {
        Console.WriteLine(message);
        result = Console.ReadLine();

        if( result.Length == 5)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели не пятизначное число . Введите корректное число");
        }
    }

    return result;
}

//функция проверяет являеься число палиндромом 
void Checkpolindromnumber(string num)
{
    if(num[0]==num[4]&& num[1]==num[3])
    {
        Console.WriteLine($"{num} - Палиндром");
    }
    else
    {
         Console.WriteLine($"{num} - НЕ Палиндром");
    }
}

string number = GetNumber("Введите пятизначное число");
Checkpolindromnumber(number);