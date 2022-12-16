/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
//получить числа с консоли


//задать матрицу и заполнить ее числами
int[,] GetMatrix(int m, int n)
{
int[,] matrix = new int[m,n];
Random rnd = new Random();

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j ] = rnd.Next(0, 10);
    }
}
return matrix;
}
//метод, который будет выдавать заполненный массив 0
double[] InitArray(int dimension)
{
    double[] array = new double[dimension];

    for (int i = 0; i < dimension; i++)
    {
        array[i] = 0;
    }

    return array;
}
//распечатать матрицу
void PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
    }
}
//Расчет среднего арифметического элементов в каждом столбце
double[] ArithmeticMean(int[,] arr)
{
    int len = arr.GetLength(0);
    double[] array = InitArray(arr.GetLength(1));
   for (int i = 0; i < arr.GetLength(1); i++)
    {
        array[i] = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            array[i]=array[i] + Convert.ToDouble(arr[j,i]);
        }
        array[i]=array[i]/len;
    } 
    return array;
}
//метод, который будет печатать массив
void PrintArray(double[] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("{0:f1}", array[i] );
        Console.Write("; ");
    }
    Console.WriteLine();
}

int[,] matrix = GetMatrix(3,4);
PrintMatrix(matrix);
double[] arr = ArithmeticMean(matrix);
PrintArray(arr);







