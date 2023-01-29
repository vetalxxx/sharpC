// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int SumElemOddPosition(int[] arr)
{
  int result = 0;
  int length = arr.Length;
  for (int i = 0; i < length; i++)
  {
    if (i % 2 != 0) result += arr[i];
  }
  return result;
}

int[] FillArray(int number, int start, int finish)
{
  int[] arr = new int[number];
  for (int i = 0; i < number; i++)
  {
    arr[i] = new Random().Next(start, finish + 1);
  }
    return arr;
}8

int GetNum(string text)
{
  Console.Write(text);
  return int.Parse(Console.ReadLine());
}

int num = GetNum("Из скольки элементов состоит массив?: ");
int startRandom = GetNum("От какого числа будем генерировать рандом? : ");
int finishRandom = GetNum("До какого числа будем генерировать рандом? : ");
int[] array = FillArray(num, startRandom, finishRandom);
int sumElements = SumElemOddPosition(array);
Console.Write("[" + String.Join(", ", array) + "]");
Console.Write(" -> " + sumElements);