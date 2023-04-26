// Task 1.Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

/*
Console.Write("Введите количество элементов массива-> ");
int a = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[a];

void massiv(int a)
{
  Console.Write("[");
  for (int i = 0; i < a; i++)
  {
    randomArray[i] = new Random().Next(99,999);
    Console.Write(randomArray[i] + ",");
  }
  Console.Write("]");
  Console.WriteLine();
}

int kolNumber(int[] randomArray)
{
 int count = 0;
 for (int i = 0; i < randomArray.Length; i++)
  {
   if (randomArray[i] % 2 == 0)
   count++;
  }
return count;
}

massiv(a);
Console.Write("Количество четных чисел -> " +kolNumber(randomArray));
*/

// Task 2.Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

/*
void ShouArray(int[] array)
{
  Console.Write("[");
  for (int i = 0; i < array.Length; i++)
    Console.Write(array[i] + ",");
    Console.Write("]");
  Console.WriteLine();
}

int[] RandomArray(int size, int min, int max)
{
  int[] array = new int[size];
  for (int i = 0; i < size; i++)
    array[i] = new Random().Next(min,max+1);
  return array;
}

int ChotNumber(int[] array )
{
  int sum = 0;
  int i = 0;
  while (i < array.Length)
  {
    sum = sum + array[i];
    i = i + 2;
  }
  return sum;
}

Console.Write("Введите количество элементов-> ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальный элемент-> ");
int minim = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный элемент-> ");
int maxim = Convert.ToInt32(Console.ReadLine());

int[] myArray = RandomArray(size, minim, maxim);
ShouArray(myArray);
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях -> " + ChotNumber(myArray));
*/

// Task 3.Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

void ShouArray(double[] array)
{
  Console.Write("[");
  for (int i = 0; i < array.Length; i++)
    Console.Write(array[i] + ",");
    Console.Write("]");
  Console.WriteLine();
}

double[] RandomArray(double size)
{
  int[] array = new int[size];
  for (int i = 0; i < size; i++)
    array[i] = new Random().NextDouble(size);
  return array;
} 
  
double raznica(double[] randomArray)
{
  double min = randomArray[0];
  double max = randomArray[0];
  int i = 1;
  while (i < randomArray.Length)
  {
    if (max<randomArray[i])
    max = randomArray[i];
      if (min>randomArray[i])
      min = randomArray[i];
      i++;
  }
  return max-min;
}

Console.Write("Введите количество элементов-> ");
double size = Convert.ToDouble(Console.ReadLine());

double[] myArray = RandomArray(size);
ShouArray(myArray);
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях -> " + raznica(myArray));