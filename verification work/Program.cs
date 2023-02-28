// Задача
// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> [ "-2" ]
// ["Russia", "Denmark", "Kazan"] -> [ ]

string[] NewArray(string[] arr)
{
  string[] array = new string[arr.Length];
  int count = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i].Length <= 3)
    {
      array[count] = arr[i];
      count++;
    }
  }
  Array.Resize(ref array, count);
  return array;
}

string[] GetArray(int number)
{
  string[] arr = new string[number];
  for (int i = 0; i < number; i++)
  {
    arr[i] = GetString($"Введите {i + 1} - строку в ваш массив: ");
  }
  return arr;
}

string GetString(string text)
{
  Console.Write(text);
  return Convert.ToString(Console.ReadLine());
}

int numberRows = int.Parse(GetString("Введите количество строк, которые вам необходимы: "));
string[] array = GetArray(numberRows);
Console.Write("[" + String.Join(", ", array) + "] -> ");
string[] arrayNew = NewArray(array);
Console.WriteLine("[" + String.Join(", ", arrayNew) + "]");
