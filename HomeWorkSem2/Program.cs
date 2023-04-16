//Home Work 

//Task 1. Напишите программу, которая принимает на вход трехзначное число 
//и на выходе показывает вторую цифру этого числа.

/*
int NewNumber(int num)
{
  int result = (num%100)/10;
  return result;
}
Console.WriteLine("Input is number: ");
int result=Convert.ToInt32(Console.ReadLine());
int unitsNumber = NewNumber(result);
Console.WriteLine($"Result: {unitsNumber}");
*/

//Task 2. Напишите программу, коорая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.

/*
bool Check(int Number)
{
  if (Number < 100)
    return false;
  else
    return true;
}
int CutNumber(int meaning)
{
  while (meaning > 999)
  {
    int hundredtsh = meaning / 10;
  }
  return meaning % 10;
}

Console.WriteLine("Input is Number: ");
int result = Convert.ToInt32(Console.ReadLine());
int newNumber = CutNumber(result);
if (Check(result) != true)
  Console.WriteLine($"Entered Number: {result} There is no third digit");
else
  Console.WriteLine($"Entered Number: {result} Thirt digit: {newNumber}");
*/

//Task 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//и проверяет, является ли этот день выходным.

/*
bool DayNumber(int number)
{
  if (number >= 6 && number < 8)
    return true;
  else
    return false;
}

Console.WriteLine("Input is number: ");
int arg = Convert.ToInt32(Console.ReadLine());
bool result = DayNumber(arg);
Console.WriteLine($"Today is {arg} - {result}");
*/