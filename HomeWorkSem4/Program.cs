// Task 1.Напишите цикл, который принимает на вход 2 числа (А и В) 
// и возводит число А в натуральную степень В.

int Prompt(string message)
{
  Console.Write(message);
  string readInput = System.Console.ReadLine();
  int result = int.Parse(readInput);
  return result;
}

int Power(int powerBase, int exponent)
{
  int power = 1;
  for(int i=0;i<exponent;i++)
  {
   power*=powerBase;
  }
  return power;
}

bool ValidateExponent(int exponent)
{
  if(exponent<0)
  {
    Console.WriteLine("Показатель не должен быть меньше нуля ");
    return false;
  }
  return true;
}

/*
int powerBase = Prompt("Введите основание-> ");
int exponent = Prompt("Введите показатель-> ");
if (ValidateExponent(exponent))
{
  Console.WriteLine($"Число {powerBase} в степени {exponent} равно {Power(powerBase,exponent)}");
}
*/

// Task 2.Напишите программу, 
// котора принимает на вход число и выдает сумму цифр в числе.

int SumALLDigit(int number)
{
  int result=0;
  while(number>0)
  {
    result +=number%10;
    number = number/10;
  }
  return result;
}

/*
int number = Prompt("Введите число-> ");
Console.WriteLine($"Сумма всех чисел в цикле {number} = {SumALLDigit(number)}");
*/

// Task 3.Напишите программу, которая задает массив из 8 элементов, 
// выводит их на экран.

int [] GenerateArray( int Lenght, int minValue, int maxValue)
{
  int[] array=new int[Lenght];
  Random random=new Random();
  for(int i=0;i<Lenght;i++)
  {
    array[i]=random.Next(minValue,maxValue+1);
  }
  return array;
}

void PrintArray(int[] array)
{
  Console.Write("[");
  for(int i=0;i<array.Length-1;i++)
  {
    Console.Write($"{array[i]}, ");
  }
  Console.Write($"{array[array.Length-1]}");
  Console.WriteLine("]");
}

int length=Prompt("Длина массива-> ");
int min = Prompt("Начальное значение-> ");
int max=Prompt("Конечное значение-> ");
int[] array= GenerateArray(length,min,max);
PrintArray(array);