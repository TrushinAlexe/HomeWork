// Seminar2

// Task 1. Напишите программу, которая вводит случайное трехзначное число
// и удаляет вторую цифру этого числа.

/*
int CutNumber(int num)
{
  int hundreds = num / 100;
  int units = num % 10;
  int result = hundreds * 10 + units;
  return result;
}

int randNumber = new Random().Next(100,1000);
int shortNumber = CutNumber(randNumber);
Console.WriteLine($"New version of {randNumber} is {shortNumber}");
*/

//Task 2. Напишите программу,  которая выводит случайное число из отрезка (10,99)
//и показывает наибольшую цыфру числа.

/*
int MaxNumber(int num)
{
  int units = num % 10;
  int dozents = num / 10;
  if (units > dozents)
  return units;
  else return dozents;
}

int random = new Random().Next(10,100);
int randomNumber = MaxNumber(random);
Console.WriteLine($"Random is {random}");
Console.WriteLine($"Random number is {randomNumber}");
*/

//Task 3. Напишите программу, которая будет принимать на вход два числа и выводить,
//является ли второе число кратным первому.

/*
bool Even(int num1, int num2)
{
  if(num2%num1==0)
  return true;
  else 
  return false;
}

Console.WriteLine("Input first number, ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number, ");
int num2 = Convert.ToInt32(Console.ReadLine());
bool result = Even(num1,num2);
Console.WriteLine(result);
*/

//Task 4. Напишите программу, которая принимает на вход число N 
//и проверяет, кратно ли оно одновременно a и b.

/*
bool Even(int num1, int num2, int arg)
{
  if (num1 % arg == 0 && num2 % arg == 0)
    return true;
  else
    return false;
}

Console.WriteLine("Input first number, ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number, ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third number, ");
int arg = Convert.ToInt32(Console.ReadLine());
bool result = Even(num1, num2, arg);
Console.WriteLine(result);
*/

//Task 5. Напишите программу, которая принимает на вход два числа и проверяет, 
//является ли одно число квадратом другого.

/*
bool Square(int num1, int num2)
{
  if ((num1 * num1 == num2) || (num2 * num2 == num1))
    return true;
  else
    return false;
}

Console.WriteLine("Input first number, ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number, ");
int num2 = Convert.ToInt32(Console.ReadLine());
bool result = Square(num1, num2);
Console.WriteLine(result);
*/