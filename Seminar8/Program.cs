
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

void ReverseArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
    for (int j = i + 1; j < array.GetLength(1); j++)
    {
      int temp = array[i, j];
      array[i, j] = array[j, i];
      array[j, i] = temp;
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

int[,] array = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(array);
ReverseArray(array);
Show2dArray(array);

*/

// Task 1.Задайте двумерный массив. Напишите прогррамму , 
// которая поменяет местами выбранную строку массива.

// int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
// {
//   int[,] array = new int[rows, columns];
//   for (int i = 0; i < rows; i++)
//     for (int j = 0; j < columns; j++)
//       array[i, j] = new Random().Next(minValue, maxValue + 1);
//   return array;
// }

// void Show2dArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//       Console.Write(array[i, j] + " ");
//     Console.WriteLine();
//   }
//   Console.WriteLine();
// }

// void RandomChangeRow(int[,]array,int row1, int row2)
// {
//   if(row1<array.GetLength(0)&& row2<array.GetLength(0)&&row1>=0&&row1>=0)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       int temp=array[row1,j];
//       array[row1,j]=array[row2,j];
//       array[row2,j]=temp;
//     }
//   }  
//   else
//   Console.WriteLine("Sorry, I cannot :c ");
// }

// Console.WriteLine("Input a quantity of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input a quantity of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input a min possible value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input a max possible value: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input row1: ");
// int row1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input row2: ");
// int row2 = Convert.ToInt32(Console.ReadLine());

// int[,] array = CreateRandom2dArray(rows, columns, minValue, maxValue);
// Show2dArray(array);
// // RandomChangeRow(array,row1,row2);
// Show2dArray(array);

// Task 2.Из двумерного массива целых чисел удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.

/*

void DeleteRowAndColumn(int[,]array, int []coord)
{
  for (int i = 0; i < array.GetLength(0); i++) array[i,coord[1]]=0;
  for (int j = 0; j < array.GetLength(1); j++) array[coord[0],j]=0;
}

int[]MinimumElement(int[,]array)
{
  int min = array[0,0];
  int minX=0;
  int minY=0;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if(array[i,j]<min)
      {
        min=array[i,j];
        minX=i;
        minY=j;
      }
    }
  }
  int[]coord = {minX,minY};
  return coord;
}

int[,] array = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(array);
int[] result = MinimumElement(array);
DeleteRowAndColumn(array,result);
Show2dArray(array);

*/