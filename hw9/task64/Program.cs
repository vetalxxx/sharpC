// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string RecursionsMoreToLess(int numberN)
{
  if (numberN == 1) return numberN.ToString();
  return(numberN + ", " + RecursionsMoreToLess(numberN - 1));
}

int GetNumArr(string text)
{
  Console.Write(text);
  return int.Parse(Console.ReadLine());
}

int n = GetNumArr("Введи число N больше нуля: ");
Console.WriteLine(RecursionsMoreToLess(n));