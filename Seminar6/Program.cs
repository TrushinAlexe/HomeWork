// Seminar 6
// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.

/*
bool IsTriangle(int arg1, int arg2, int arg3)
{
  if (arg1 <arg2 + arg3 && arg2 < arg1 + arg3 && arg3 < arg1 + arg2)
    return true;
  else return false;
}

Console.Write("Input a length of the first edge: ");
int edge1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a length of the second edge: ");
int edge2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a length of the third edge: ");
int edge3 = Convert.ToInt32(Console.ReadLine());
bool Treug = IsTriangle(edge1,edge2,edge3);
Console.WriteLine(Treug);
*/

//Не используя рекурсию, выведите первые N чисел Фибоначчи. 
//Первые два числа Фибоначчи: 0 и 1.

/*
int[] Fibonachi(int N)
{
  int[] array = new int[N];
  array[0]=0;
  array[1]=1;
  for (int i = 2; i < array.Length; i++)
   {
   array[i]=array[i-1]+array[i-2];
   }
  return array;
}
*/

// Напишите программу, которая будет 
// создавать копию заданного массива с помощью поэлементного копирования.

/*
int[] GetCopyArray(int[] array)
{
  int[] newArray = new int[array.Length];
  for (int i = 0; i < array.Length; i++)
  {
    newArray[i] = array[i];
  }
  return newArray;
}
*/
