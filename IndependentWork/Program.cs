//Task 1.Вывести на экран число  с точностью до сотых.

/*
double number = new Random().NextDouble();
Console.WriteLine($"Ваше число-> {Math.Round(number,2)} ");
*/

//Task 2.Вывести на экран число e 
//(основание натурального логарифма) с точностью до десятых.

/*
double random = new Random().NextDouble();
Console.WriteLine($"Ваше число-> {Math.Round(random,1)} ");
*/

//Task 3.Составить программу вывода на экран числа, вводимого с клавиатуры. 
//Выводимому числу должно предшествовать сообщение «Вы ввели число».

/*
Console.WriteLine("Введите число-> ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вы ввели число-> {number}");
*/

//Task 4.Вывести на одной строке числа 1, 13 и 49 с одним пробелом между ними.

/*
Console.WriteLine("Введите первое число-> ");
int number=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число число-> ");
int number1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число-> ");
int number2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вы ввели -> {number} {number1} {number2}");
*/

//Task 5.Составить программу вывода на экран 
//в одну строку трех любых чисел с двумя пробелами между ними.

/*
int number=new Random().Next(10,100);
int number1=new Random().Next(10,100);
int number2=new Random().Next(10,100);
Console.WriteLine($"Числа-> {number}  {number1}  {number2} ");
*/

//Task 6.Вывести на экран числа 50 и 10 одно под другим.

/*
int number=50;
int number1=10;
Console.WriteLine($"{number}");
Console.WriteLine($"{number1}");
*/

//Task 6.Составить программу:
//а) вычисления значения функции y=7x2+3x+6 при любом значении x;
//б) вычисления значения функции x=12a2+7a+12 при любом значении а.

/*
Console.WriteLine("Введите число-> ");
int x=Convert.ToInt32(Console.ReadLine());
int prois = (7*x)*2;
int prois1 = 3*x;
int result = prois+prois1+6;
Console.WriteLine("Ответ-> "+result);
*/

//Task 7.Дано расстояние в сантиметрах. Найти число полных метров в нем.

/*
Console.WriteLine("Введите растояние в см-> ");
double number = Convert.ToDouble(Console.ReadLine());
double prois=number/100;
Console.WriteLine($"Расстояние в метрах-> {prois}");
*/

//Task 8.Создать двумерный массив:

/*
void PrintArray(int[,] matrix)
{
  {
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        Console.Write($" {matrix[i, j]} ");
      }
      Console.WriteLine();
    }
  }
}

void FillArray(int[,]matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
     matrix[i,j]=new Random().Next(1,10); 
    }
  }
  Console.WriteLine();
}

int[,] matrix = new int[5, 9];

PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);
*/

//Task 9.Создать картинку в двумерном масиве.

/*

int[,] pic = new int[,]
{
  {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
  {0,0,0,0,0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0},
  {0,0,0,0,0,0,0,0,0,0,0,1,0,0,1,0,0,0,0,0,0,0,0,0,0},
  {0,0,0,0,0,0,0,0,0,0,0,1,0,0,1,0,0,0,0,0,0,0,0,0,0},
  {0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0},
  {0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0},
  {0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0},
  {0,0,0,0,0,0,0,1,1,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0},
  {0,0,0,0,0,1,1,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0},
  {0,0,1,1,1,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,0,0,0,0},
  {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0},
  {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0},
  {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0},
  {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0},
  {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0},
  {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0},
  {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0},
  {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0},
  {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0,0},
  {0,0,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0},
  {0,0,0,0,0,0,0,1,1,1,1,0,0,0,0,0,0,0,1,0,0,0,0,0,0},
  {0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,0,0,0,0,0,0,0},
  {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
};

void PrintImaget(int[,] image)
{
  {
    for (int i = 0; i < image.GetLength(0); i++)
    {
      for (int j = 0; j < image.GetLength(1); j++)
      {
        //Console.Write($" {matrix[i, j]} ");
        if (image[i, j] == 0) Console.Write($" ");
        else Console.Write($"+");
      }
      Console.WriteLine();
    }
  }
}

void FillImage(int rew, int col)
{
  if (pic[rew, col] == 0)
  {
    pic[rew, col] = 1;
    FillImage(rew - 1, col);
    FillImage(rew, col - 1);
    FillImage(rew + 1, col);
    FillImage(rew, col + 1);
  }
}

PrintImaget(pic);
FillImage(13, 13);
PrintImaget(pic);
*/

//Task 10.Написать программу вычисления факториала.

/*
double Factorial(double n)
{
  // 1! = 1
  // 0! = 1
  if (n == 1) return 1;
  else return n* Factorial(n - 1);
}
for (int i = 1; i < 40; i++)
{
  Console.WriteLine($"{i}! = {Factorial(i)}");
}
*/

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1)+f(n-2)

/*
double Fibonacci(int n)
{
  if (n == 1 || n == 2) return 1;
  else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
for (int i = 1; i < 40; i++)
{
  Console.WriteLine($"f{i} = {Fibonacci(i)}");
}
*/


