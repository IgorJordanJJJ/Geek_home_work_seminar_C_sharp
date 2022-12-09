/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
Ха кринж ошибка в задании тут число должно было быть 4 а не 3 т.к. тут 4 числа больше 0*/

//получение числа с консоли, для того, чтобы задать размерность массива
int ChekcNumberFromConsole(string message)
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
            Console.WriteLine("Ввели не число. Введите число");
        }
    }

    return result;
}
//получение числа с консоли, для того, чтобы задать размерность массива
int GetNumberFromConsole(string message)
{
    bool isCorrect = false;
    string messeg_user = "";
    int num = 0;
    int count =0;

    while(!isCorrect)
    {
        Console.WriteLine(message);
        Console.WriteLine("Если да то напишите д, если нет то н");
        messeg_user = Console.ReadLine();

        if(messeg_user == "д")
        {
            num = ChekcNumberFromConsole("Введите число");
            if(num>0)
            {
                count++;
            }
        }
        else if(messeg_user == "н")
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели не д не н. Введите число");
        }

    }

    return count;
}

int num = GetNumberFromConsole("Хотите ввесьти число");
Console.WriteLine($"Количество введённых положительных чисел = {num}");