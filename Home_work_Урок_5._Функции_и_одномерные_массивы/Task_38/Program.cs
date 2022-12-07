/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/
//инициализирует новый массив
int[] InitArray(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(0,1000);
    }

    return array;
}

//печатает массив на экран
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
//получает максимальное число в массиве 
int GetMaxNumber(int[] arr)
{
    int max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if(max < arr[i])
            max = arr[i];
    }

    return max;
}
//получает минимальное число в массиве 
int GetMinNumber(int[] arr)
{
    int min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if(min > arr[i])
            min = arr[i];
    }

    return min;
}
int[] arr = InitArray(10);
PrintArray(arr);
int max = GetMaxNumber(arr);
int min = GetMinNumber(arr);
Console.WriteLine($"Разницу между максимальным и минимальным элементов массива = {max-min}");