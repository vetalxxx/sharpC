// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumFromMBeforeN(int numberM, int numberN)
{
  if (numberM == numberN) return numberM;
  if (numberM < numberN) return numberM + SumFromMBeforeN(numberM + 1, numberN);
  else return numberN + SumFromMBeforeN(numberM, numberN + 1);
}

int GetNum(string text)
{
  Console.Write(text);
  return int.Parse(Console.ReadLine());
}

int m = GetNum("Введи число M больше нуля: ");
int n = GetNum("Введи число N больше нуля: ");
int result = SumFromMBeforeN(m, n);
Console.Write(result);