/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/
//инициализирует новый массив
int[] InitArray(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(-1000,1000);
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
//получаем сумму чисел на ченых позициях в массиве
int GetSumEvenNumber(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i=i+2)
    {
        sum += arr[i];
    }

    return sum;
}
int[] arr = InitArray(10);
PrintArray(arr);
int sum = GetSumEvenNumber(arr);
Console.WriteLine($"Сумма чисел на ченых позициях в массиве = {sum}");
