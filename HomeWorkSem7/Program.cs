//Task 1.Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.

/*
void CreateRandomDoubleArray(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
      array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
}

void ShowArray(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      Console.Write(array[i,j]+ " ");
    Console.WriteLine();  
  }
  Console.WriteLine();
}

Console.WriteLine("Input a quantity of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a quantity of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] myArray =  new double[rows, columns];
CreateRandomDoubleArray(myArray);
ShowArray(myArray);
*/

//Task 2.Напишите программу, 
//которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, 
//что такого элемента нет.

/*
int[,] CreateRandomArray(int rows, int columns, int minValue, int maxValue)
{
  int[,] array = new int[6, 6];
  for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
      array[i, j] = new Random().Next(minValue, maxValue + 1);
  return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.WriteLine(""); 
    }
}

Console.WriteLine("Input a quantity of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a quantity of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandomArray(rows,columns,minValue,maxValue);
PrintArray(myArray);

if (rows > myArray.GetLength(0) || columns > myArray.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {rows} строки и {columns} столбца равно {myArray[rows-1,columns-1]}");
}
*/

//Task 3.Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

/*
Console.WriteLine("Input a quantity of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a quantity of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows,columns,minValue,maxValue);
PrintArray(myArray);
SredneeAr(myArray);

void SredneeAr(int[,] array)
{
  for (int j = 0; j < myArray.GetLength(1); j++)
  {
    double srednee = 0;
    for (int i = 0; i < myArray.GetLength(0); i++)
        srednee = (srednee + myArray[i, j]);
  srednee = srednee / rows;
  Console.Write(Math.Round(srednee,2) + "; ");
  }
} 

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
  int[,] array = new int[rows, columns];
  for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
      array[i, j] = new Random().Next(minValue, maxValue + 1);
  return array;
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}
*/
