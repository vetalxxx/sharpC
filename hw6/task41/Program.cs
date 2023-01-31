// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int PositiveNumber(int[] arr)
{
  int count = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] > 0) count += 1;
  }
  return count;
}

int[] GetArr(int num)
{
  int[] arr = new int[num];
  for (int i = 0; i < num; i++)
  {
    arr[i] = GetNum($"Введи {i + 1} - ое число : ");
  }
  return arr;
}

int GetNum(string text)
{
  Console.Write(text);
  return int.Parse(Console.ReadLine());
}

int number = GetNum(" Сколько чисел ты хочешь ввести? : ");
int[] array = GetArr(number);
Console.Write($"[{String.Join(", ", array)}] -> ");
int posNum = PositiveNumber(array);
Console.WriteLine(posNum);