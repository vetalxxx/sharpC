// Задача 13: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int num = -1;
while (number > 999)
{
  number = number / 10;
  num = number % 10;
}
Console.WriteLine($"Получаем такое число: {number}");
if (number / 100 < 1)
{
  Console.WriteLine("Третьей цифры нет");
}
else
{
  num = number % 10;
  Console.WriteLine($"Наша искомая третья цифра из введенного числа: {num}");
}


