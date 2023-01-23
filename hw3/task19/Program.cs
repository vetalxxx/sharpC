// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// int[] array = { 1,4,2,4,1 };
// int i = 0;
// while (array[i] == array[array.Length - 1 - i] && i < array.Length - 1 - i)
// {
//   i++;
// }
// if (i == array.Length / 2) { Console.WriteLine("палиндромом"); }
// else Console.WriteLine("палиндрома не видать");

int GetNum(string text)
{
  Console.WriteLine(text);
  return int.Parse(Console.ReadLine());
}

void Palindrome(int number)
{
  if (number % 10 == number / 10000)
  {
    if ((number / 1000) % 10 == (number / 10) % 10)
    {
      Console.WriteLine("палиндром есть");
    }
    else Console.WriteLine("палиндрома нет");
  }
  else Console.WriteLine("палиндрома нет");
}

int num = GetNum("Введите 5 значное число: ");

Palindrome(num);