/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */
Console.WriteLine("Hello, World!");

// функция Аккермана
int Acerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Acerman(n - 1, 1);
    else
      return Acerman(n - 1, Acerman(n, m - 1));
}

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
            Console.WriteLine("Ввели не верные данные. Введите число, которое больше 0");
        }
    }

    return result;
}

int m = GetNumberFromConsole("Введите число m");
int n = GetNumberFromConsole("Введите число n");
int acer = Acerman(m,n);
Console.WriteLine($"Рзультат функции Акерман {acer}");