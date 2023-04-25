//Seminar 3

// double.Math.Pow(a,b)- вычесляет квадрат!
// double.Math.Sqrt(a) - вычесляет корень квадратный!
// double.Math.Round(a,b) - округляет число!

//Task 1. Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

/*
void ScouRenge(int quad)
{
  if(quad==1)Console.WriteLine("x>0 and y>0");
  else if(quad == 2)Console.WriteLine("x<0 and y>0");
  else if(quad == 3)Console.WriteLine("x<0 and y<0");
  else if(quad == 4)Console.WriteLine("x>0 and y<0");
  else Console.WriteLine("Wrong number of quadrant! ");
}

Console.WriteLine("Input a number of quadrant: ");
int quadrant = Convert.ToInt32(Console.ReadLine());
ScouRenge(quadrant);
*/

//Task 2.Напишите программу, которая принимает на вход координаты точки (X и Y), 
//и выдаёт номер четверти плоскости, в которой находится эта точка.

/*
int ReturneCoord(double x, double y)
{
  int coord;
  if (x > 0 && y > 0)
  {
    return coord = 1;
  }
  else if (x < 0 && y > 0)
  {
    return coord = 2;
  }
  else if (x < 0 && y < 0)
  {
    return coord = 3;
  }
  else if (x > 0 && y < 0)
  {
    return coord = 4;
  }
  else return coord = 0;

}
Console.WriteLine("Input enter coord x ");
double coordX = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input enter coord y ");
double coordY = Convert.ToDouble(Console.ReadLine());
double returnRes = ReturneCoord(coordX, coordY);
Console.WriteLine($"Ваша координатная плоскость {returnRes}");
*/

//Task 3. Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу квадратов чисел от 1 до N.

/*
void TablKvad (int N)
{
  int count =1;
  while(count<=N)
  {
    Console.WriteLine($"Квадрат {count} составит - {count*count}");
    count++;
  }
}
Console.WriteLine("Введите значение: ");
int n =Convert.ToInt32(Console.ReadLine());
TablKvad(n);
*/

//Task 4. Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве

/*
double Gipot(double x1,double y1,double x2,double y2)
{
  double distX= x2-x1;
  double distY= y2-y1;
  double result= Math.Sqrt(distX*distX+distY*distY);
  return result;
}
Console.Write("Введите значение x1: ");
double x1 =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение y1: ");
double y1 =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение x2: ");
double x2 =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение y2: ");
double y2 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Расстояние между точками 1 и 2 соствляет: {Math.Round(Gipot(x1,y1,x2,y2),3)} ");
*/

