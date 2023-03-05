//Задайте двумерный массив размера m*n по формуле :a[i,j]=i+j Вывод массива на экран.
using System;
using static System.Console;
Console.Clear();
Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write("Введите количество столбов массива: ");
int columns = int.Parse(ReadLine());
int[,] array = GetArray(rows, columns );
PrintArray (array);
int[,]GetArray(int m, int n)
{
    int [,] result = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n ; j++)
        {
            result[i,j]=i+j;
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}