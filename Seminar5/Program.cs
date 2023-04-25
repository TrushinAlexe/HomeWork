//Seminar 5

// void ShowArrey(int[] array)
// {
//   for (int i = 0; i < array.Length; i++)
//     Console.Write(array[i] + " ");
//   Console.WriteLine();
// }

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//   int[] array = new int[size];

//   for (int i = 0; i < size; i++)
//     array[i] = new Random().Next(minValue, maxValue + 1);

//   return array;
// }

// int GetSumOfNegatives(int[] array)
// {
//   int sum = 0;
//   for (int i = 0; i < array.Length; i++)
//     if (array[i] < 0)
//       sum += array[i]; // sum = sum+array[i];
//   return sum;
// }

/*
Console.Write("Inpud a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Inpud a min of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Inpud a max of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArrey = CreateRandomArray(size, min, max);
ShowArrey(myArrey);
Console.Write($"Sum of negative elements is " + GetSumOfNegatives(myArrey));
*/

//1 Напишите программу, замена элементов массива, 
//положительные элементы замените на соответствующие отрицательные, и наоборот.

/*
int[] CheingArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
   array[i]=array[i]*(-1);
  return array;
}

Console.Write("Inpud a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Inpud a min of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Inpud a max of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArrey = CreateRandomArray(size, min, max);
ShowArrey(myArrey);
CheingArray(myArrey);
ShowArrey(myArrey);
*/

//2 Задайте массив. Напишите программу, 
//которая определит, присутствует ли заданное число в массиве.

/*
bool IsNumberInArray(int[] array, int number)
{
  for (int i = 0; i < array.Length; i++)
    if (array[i] == number)
    {
      Console.Write("Есть номер ");
      return true;
    }  
  Console.Write("Нет номера ");
  return false;
}

Console.Write("Inpud a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Inpud a min of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Inpud a max of elements: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число-> ");
int num = Convert.ToInt32(Console.ReadLine());

int[] myArrey = CreateRandomArray(size, min, max);
ShowArrey(myArrey);
IsNumberInArray(myArrey,num);
*/

//3 Задайте одномерный массив из М случайных чисел.
//Найдите количество элементов массива ,значения которых лежат в отрезке (А,В).

/*
int GetQtyElements(int[] array, int minValue, int maxValue)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
    if (array[i] <= maxValue && array[i] >= minValue)
      count++;
  return count;
}

Console.Write("Inpud a arrey size(>0) > ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Inpud a min of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Inpud a max of elements: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArrey(myArray);
GetQtyElements(myArray,numA,numB);
Console.WriteLine("Количество элементов в пределах составляет-> "+ GetQtyElements(myArray,numA,numB));
*/
