﻿// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

void ShowArray(double[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write(Math.Round(arr[i, j], 1) + "\t");
    }
    Console.WriteLine();
  }
}

double[,] GenerateArray(int rows, int columns, int lowerBound, int upperBound)
{
  double[,] array = new double[rows, columns];
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      array[i, j] = new Random().NextDouble() * (upperBound - lowerBound) + lowerBound ;
    }
  }
  return array;
}

int GetNum(string text)
{
  Console.Write(text);
  return int.Parse(Console.ReadLine());
}
// получить значение от пользователя
int m = GetNum("Введите количество строк: ");
int n = GetNum("Введите количество столбцов: ");
// генерация массива
double[,] array = GenerateArray(m, n, -10, 10);
ShowArray(array);
