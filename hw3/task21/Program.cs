// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
int GetNum(string text)
{
  Console.WriteLine(text);
  return int.Parse(Console.ReadLine());
}

void DistanceBetween(int ax, int ay, int az, int bx, int by, int bz)
{
  double result = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));
  Console.WriteLine(result);
}

int ax = GetNum("Ведите координату х первого числа: ");
int ay = GetNum("Ведите координату y первого числа: ");
int az = GetNum("Ведите координату z первого числа: ");
int bx = GetNum("Ведите координату x второго числа: ");
int by = GetNum("Ведите координату y второго числа: ");
int bz = GetNum("Ведите координату z второго числа: ");

DistanceBetween(ax, ay, az, bx, by, bz);