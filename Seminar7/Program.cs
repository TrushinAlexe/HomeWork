//Seminar 7

/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
  int[,] array = new int[rows, columns];
  for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
      array[i, j] = new Random().Next(minValue, maxValue + 1);
  return array;
}

void Show2dArray(int[,] array)
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
Console.WriteLine("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows,columns,minValue,maxValue);
Show2dArray(myArray);
*/

// Task 1.Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находиться по формуле: Aij=i+j.
// Вывдите полученный массив на экран.

/*
int[,] CreatArray(int rows, int columns)
{
  int[,] array = new int[rows, columns];
  for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
      array[i, j] = i+j;
  return array;
}

void Show2dArray(int[,] array)
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

int[,] myArray=CreatArray(rows,columns);
Show2dArray(myArray);
*/

//Task 2.Задайте двумерный массив.Найдите элементы, 
//у которых оба индекса четные, и замените эти элементы на их квадраты.

/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
  int[,] array = new int[rows, columns];
  for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
      array[i, j] = new Random().Next(minValue, maxValue + 1);
  return array;
}

void EventIndexArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i = i + 2)
    for (int j = 0; j < array.GetLength(1); j += 2)
      array[i, j] *= array[i, j];
}

void Show2dArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      Console.Write(array[i, j] + " ");
    Console.WriteLine();
  }
  Console.WriteLine();
}

Console.WriteLine("Input a quantity of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a quantity of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);
EventIndexArray(myArray);
Show2dArray(myArray);
*/

//Task 3.Задайте двумерный массив.Найдите сумму элементов, 
//находящихся на главной диагонали(с индексами (0,0);(1,1))и т.д.

/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
  int[,] array = new int[rows, columns];
  for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
      array[i, j] = new Random().Next(minValue, maxValue + 1);
  return array;
}

int DiagSum(int[,] array)
{
  int sum = array[0, 0];
  for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
    sum = sum + array[i, i];
  return sum;
}

void Show2dArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      Console.Write(array[i, j] + " ");
    Console.WriteLine();
  }
  Console.WriteLine();
}


Console.WriteLine("Input a quantity of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a quantity of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);
Console.WriteLine($"Сумма элементов {DiagSum(myArray)}");
*/