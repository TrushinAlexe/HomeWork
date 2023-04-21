
void ShowArrey(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
  Console.WriteLine();
}

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
  int[] array = new int[size];

  for (int i = 0; i < size; i++)
    array[i] = new Random().Next(minValue, maxValue + 1);

  return array;
}

int GetSumOfNegatives(int[] array)
{
  int sum = 0;
  for (int i = 0; i < array.Length; i++)
    if (array[i] < 0) sum += array[i]; // sum = sum+arrey[i];
  return sum;
}

// Console.Write("Inpud a quantity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Inpud a min of elements: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Inpud a max of elements: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArrey = CreateRandomArray(size, min, max);
// ShowArrey(myArrey);
// Console.Write($"Sum of negative elements is " + GetSumOfNegatives(myArrey));

//1
/*
void ShowArrey(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  Console.Write(array[i] + " ");
  Console.WriteLine();
}

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
  int[] array = new int[size];

  for (int i = 0; i < size; i++)
    array[i] = new Random().Next(minValue, maxValue + 1);

  return array;
}

Console.Write("Inpud a arrey size(>0) > ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Inpud a min of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Inpud a max of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArrey = CreateRandomArray(size, min, max);
ShowArrey(myArrey);
Console.Write($"Sum of negative elements is " + GetSumOfNegatives(myArrey));
*/

//2
/*
bool IsNumberInArray(int[]array,int number)
{
  bool result = false;
  for(int=i;i<array.Length;i++)
    if(array[i]==number)
    return true;
  return false;
}

Console.Write("Inpud a arrey size(>0) > ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Inpud a min of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Inpud a max of elements: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArrey = CreateRandomArray(size, min, max);
ShowArrey(myArrey);
Console.Write($"Sum of negative elements is " + GetSumOfNegatives(myArrey));
*/

//3

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
Console.WriteLine("Quntity of elements: "+ GetQtyElements(myArray, numA, numB));


//4
/*
void PutMultiplicate(int array)
{
  for(int i=0;i<array.Length/2;i++)
  arrey

}
int n = PtomptInt("Enter an array(>0) ");
int min = PromptInt("Entet a minimum element value: ");
int max = PromptInt("Entet a maximum element value: ");
int [] array = CreateRandomArray(n,min,max);
int [] array = new int [array.Length/2];
PutMultiplicate(array,array.Length/2);
PrintAraay(array);
PrintArray(arrayQut);
*/