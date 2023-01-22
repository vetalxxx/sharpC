// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int GetNum(string text)
{
  Console.Write(text);
  return int.Parse(Console.ReadLine());
}

void TableCubes(int num)
{
  int i = 1;
  while (i < num)
  {
    Console.Write(Math.Pow(i, 3) + ", ");
    i++;
  }
  Console.Write(Math.Pow(i, 3));
}

int number = GetNum("Введите число: ");

TableCubes(number);