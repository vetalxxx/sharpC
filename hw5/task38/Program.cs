// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double MaxOrMin(double[] array, bool positive)
{
  int length = array.Length;
  double maxOrMin = array[0];
  for (int i = 0; i < length; i++)
  {
    if (array[i] > maxOrMin && positive == true || array[i] < maxOrMin && positive == false)
    {
      maxOrMin = array[i];
    }
  }
  return maxOrMin;
}

double GetNumArray(string text)
{
  Console.Write(text);
  return double.Parse(Console.ReadLine()!);
}

double[] FillArray(int number)
{
  double[] arr = new double[number];
  for (int i = 0; i < number; i++)
  {
    arr[i] = GetNumArray($"Введи вещественное число для {i + 1} - ого элемента массива: ");
  }
  return arr;
}

int GetNumLengthArray(string text)
{
  Console.Write(text);
  return int.Parse(Console.ReadLine()!);
}

int num = GetNumLengthArray("Из скольки элементов состоит массив?: ");
double[] array = FillArray(num);
Console.Write("[" + String.Join(" ; ", array) + "]");
double maxElements = MaxOrMin(array, true);
double minElements = MaxOrMin(array, false);
Console.Write(" -> " + maxElements + " - " + minElements + " = " + Math.Round(maxElements - minElements, 2));
