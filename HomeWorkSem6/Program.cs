//Task 1.Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// int Prompt(string message)
// {
//   Console.Write(message);
//   string readInput = System.Console.ReadLine();
//   int result = int.Parse(readInput);
//   return result;
// }

// int[] InputArray(int length)
// {
//   int[] array = new int[length];
//   for (int i = 0; i < array.Length; i++)
//   {
//     array[i] = Prompt($"Введите {i + 1} - элемент ");
//   }
//   return array;
// }

// void PrintArray(int[] array)
// {
//   Console.Write("[");
//   for (int i = 0; i < array.Length - 1; i++)
//   {
//     Console.Write($"{array[i]} = {array[i]} ");
//   }
//   Console.WriteLine("]");
// }

// int CountPositiveNumbers(int[] array)
// {
//   int count = 0;
//   for (int i = 0; i < array.Length; i++)
//   {
//     if (array[i] > 0)
//     {
//       count++;
//     }
//   }
//   return count;
// }

/*
int length = Prompt("Введите количество элементов-> ");
int[] array;
array=InputArray(length);
PrintArray(array);
Console.WriteLine($"Количество чисел больше 0 -> {CountPositiveNumbers(array)}");
*/

//Task 2.Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

/*
const int COEFFICIENT = 0;
const int CONSTANT=1;
const int X_COORD=0;
const int Y_COORD=1;
const int LINE1=1;
const int LINE2=2;

double[] lineData1= InputLineData(LINE1);
double[] lineData2= InputLineData(LINE2);

if(ValidateLines(lineData1,lineData2))
{
  double[] coord= FindCoords(lineData1,lineData2);
  Console.Write($"Точка пересечения уравнений y= {lineData1[COEFFICIENT]}*x+{lineData1[CONSTANT]} и y= {lineData2[COEFFICIENT]}*x+{lineData2[CONSTANT]}");
  Console.WriteLine($"имеет координаты ({coord[X_COORD]},{coord[Y_COORD]})");
}


int Prompt(string message)
{
  Console.Write(message);
  string readInput = System.Console.ReadLine();
  int result = int.Parse(readInput);
  return result;
}

double[] InputLineData(int numberOfLine)
{
  double[] lineData=new double[2];
  lineData[COEFFICIENT]=Prompt($"Введите коэффициент для {numberOfLine} прямой > ");
  lineData[CONSTANT]=Prompt($"Введите коэффициент для {numberOfLine} прямой > ");
  return lineData;
}

double[] FindCoords(double[] lineData1,double[] lineData2)
{
  double[] coord=new double[2];
  coord[X_COORD]=(lineData1[CONSTANT]-lineData2[CONSTANT])/(lineData2[COEFFICIENT]-lineData1[COEFFICIENT]);
  coord[Y_COORD]=lineData1[CONSTANT]*coord[X_COORD]+lineData1[CONSTANT];
  return coord;
}

bool ValidateLines(double[] lineDate1, double[] lineData2)
{
  if(lineData1[COEFFICIENT]==lineData2[COEFFICIENT])
  {
    if(lineData1[CONSTANT]==lineData2[CONSTANT])
    {
      Console.WriteLine("Прямые совпадают ");
      return false;
    }
    else
    {
     Console.WriteLine("Прямые паралельны ");
     return false;
    }
  }
  return true;
}

*/