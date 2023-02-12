// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int RecursionAckerman(int numberM, int numberN)
{
  if (numberM == 0) return numberN + 1;
  if (numberM > 0 && numberN == 0) return RecursionAckerman(numberM - 1, 1);
  if (numberM > 0 && numberN > 0) return RecursionAckerman(numberM - 1, RecursionAckerman(numberM, numberN - 1));
  else return 0;
}

int GetNum(string text)
{
  Console.Write(text);
  return int.Parse(Console.ReadLine());
}

int m = GetNum("Введи число M больше нуля: ");
int n = GetNum("Введи число N больше нуля: ");
int result = RecursionAckerman(m, n);
Console.Write(result);