//Task 1.Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.

/*
bool CheckPalindromicNumber(int number)
{
  int i = 0;
  int num = number;
  while (number > 0)
  {
    i = i * 10 + number % 10;
    number = number / 10;
  }
  return i == num;
}
void Main()
{
  int number;
  Console.Write("Введите число-> ");
  number = Convert.ToInt32(Console.ReadLine());
  if (CheckPalindromicNumber(number))
    Console.WriteLine("Палиндром");
  else
    Console.WriteLine("Не палиндром");
}
Main();
*/

//Task 2.Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.

/*
double Distans(double x1,double y1,double z1,double x2,double y2,double z2)
{
  double pointX= Math.Pow(x2-x1,2);
  double pointY= Math.Pow(y2-y1,2);
  double pointZ= Math.Pow(z2-z1,2);
  double result= Math.Sqrt(pointX+pointY+pointZ);
  return result;
}
Console.Write("Введите значение x1: ");
double x1 =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение y1: ");
double y1 =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение z1: ");
double z1 =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение x2: ");
double x2 =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение y2: ");
double y2 =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение z2: ");
double z2 =Convert.ToInt32(Console.ReadLine());
double result=Math.Round(Distans(x1,y1,z1,x2,y2,z2),2);
Console.WriteLine($"Расстояние между двумя точками в 3D пространстве равно {result}");
*/

//Task 3.Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
void Cubing (int N)
{
  int count =1;
  while(count<=N)
  {
    Console.WriteLine($"Число -> {count} Получили -> {count*count*count}");
    count++;
  }
}
Console.WriteLine("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
Cubing(num);
*/