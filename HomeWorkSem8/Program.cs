// Task 1.Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
      Console.Write(array[i, j] + " ");
    Console.WriteLine();
  }
  Console.WriteLine();
}

void Sorting(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                  int temp = array[i, k + 1];
                  array[i, k + 1] = array[i, k];
                  array[i, k] = temp;
                }
            }
        }
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

int[,]myArray=CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);
Sorting(myArray);
Show2dArray(myArray);
*/

// Task 2.Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*
void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void NumberRowMinSumElements(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"Наименьшая сумма в {minSumRow + 1} строке");
}

int[,] myArray = new int[5, 5];
FillArrayRandom(myArray);
Show2dArray(myArray);
NumberRowMinSumElements(myArray);
*/

// Task 3.Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

/*
void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
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

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] myArray = new int[rows, columns];
int[,] secondArray = new int[rows, columns];
int[,] resultArray = new int[rows, columns];

FillArrayRandom(myArray);
Show2dArray(myArray);
FillArrayRandom(secondArray);
Show2dArray(secondArray);
Console.WriteLine();

if (myArray.GetLength(0) != secondArray.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}
for (int i = 0; i < myArray.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < myArray.GetLength(1); k++)
        {
            resultArray[i, j] += myArray[i, k] * secondArray[k, j];
        }
    }
}

Show2dArray(resultArray);
*/

// Task 4.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

/*
void PrintIndex(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

void FillArray(int[,,] arr)
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[k, i, j] += count;
                count += 3;
            }
        }
    }
}

int[,,] myArray = new int[2, 2, 2];
FillArray(myArray);
PrintIndex(myArray);
*/

// Task 5.Напишите программу, которая заполнит спирально массив 4 на 4.

/*
void FillArraySpiral(int[,] array, int n)
{
  int i = 0, j = 0;
  int value = 1;
  for (int e = 0; e < n * n; e++)
  {
    int k = 0;
    do { array[i, j++] = value++; } while (++k < n - 1);
    for (k = 0; k < n - 1; k++) array[i++, j] = value++;
    for (k = 0; k < n - 1; k++) array[i, j--] = value++;
    for (k = 0; k < n - 1; k++) array[i--, j] = value++;
    ++i; ++j;
    n = n < 2 ? 0 : n - 2;
  }
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] < 10)
      {
        Console.Write("0" + array[i, j]);
        Console.Write(" ");
      }
      else Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}

int size = 4;
int[,] myArray = new int[size, size];
FillArraySpiral(myArray, size);
PrintArray(myArray);
*/
