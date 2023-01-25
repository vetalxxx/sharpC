// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void GetDegree(int numberA, int numberB)
{
  int result = 1;
  for (int i = 1; i <= numberB; i++)
  {
    result = result * numberA;
  }
  Console.WriteLine(numberA + ", " + numberB + " -> " + result);
}

int GetNum(string text)
{
  Console.Write(text);
  return int.Parse(Console.ReadLine());
}

int numA = GetNum("Введите число А: ");
int numB = GetNum("В какую степень возвести число А?: ");

GetDegree(numA, numB);