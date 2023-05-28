//Seminar 8
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, 
//программа должна вывести сообщение для пользователя.


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

void ReverseArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0) - 1; i++)
    for (int j = i + 1; j < array.GetLength(1) - 1; j++)
    {
      
    }
}
