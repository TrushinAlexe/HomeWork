// HomeWork
//  Task 1. Напишите программу, которая на вход принимает два числа и выдаёт, 
//  какое число большее, а какое меньшее.

/*
Console.WriteLine("Inpud a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inpud a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 <= num2)
{
  Console.WriteLine("Second number is greater " + num2);
}
else
{
  Console.WriteLine("first number is greater " + num1);
}
*/

// Task 2.Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
/*
Console.WriteLine("Inpud a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inpud a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inpud a third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;
if (num1 > max) max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;
Console.WriteLine("Maximum number: "+max);
*/

// Task 2.Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

/*
Console.WriteLine("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num%2==0)// Если число делиться на 2 без остатка, то остаток от деления = 0
{
  Console.WriteLine("Yes");
}
else
{
  Console.WriteLine("No");
}
*/

// Task 4.Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.


Console.WriteLine("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 1;
while(current<=num)
{
  if(current%2==0)
  Console.WriteLine(current+" ");
  current++;
}
