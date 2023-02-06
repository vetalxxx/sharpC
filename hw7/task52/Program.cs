// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void ArithmeticMeanColumns(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(1); i++)
  {
    double result = 0;
    //int count = 0;
    for (int j = 0; j < arr.GetLength(0); j++)
    {
      result += arr[j, i];
      //count++;
    }
    double res = result / arr.GetLength(0);
    Console.Write(Math.Round(res, 1) + "\t");
  }
}

void ShowArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write(arr[i, j] + "\t");
    }
    Console.WriteLine();
  }
}

int[,] GenerateArray(int rows, int columns, int lowerBound, int upperBound)
{
  int[,] array = new int[rows, columns];
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      array[i, j] = new Random().Next(lowerBound, upperBound + 1);
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
int[,] array = GenerateArray(m, n, 0, 10);
ShowArray(array);
Console.WriteLine("Под каждым столбцом указна среднее арифметическое чисел этого столба");
ArithmeticMeanColumns(array);
