// Задача 29: Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void ShowArray(int[] arr)
{
  int length = arr.Length - 1;
  Console.Write("[");
  for (int i = 0; i < length; i++)
  {
    Console.Write(arr[i] + ", ");
  }
  Console.Write(arr[length] + "]");
}

int[] GetArray(int number)
{
  int[] array = new int[number];
  int length = array.Length;
  for (int i = 0; i < length; i++)
  {
    array[i] = GetNumArr($"Введи {i + 1}-ое число в массив: ");
  }
  return array;
}

int GetNumArr(string text)
{
  Console.Write(text);
  return int.Parse(Console.ReadLine());
}

int num = GetNumArr("Из скольки элементов состоит массив?: ");
ShowArray(GetArray(num));