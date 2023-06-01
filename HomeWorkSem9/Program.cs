// Task 1.Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

/*
void ShowIntNum(int n)
{
  Console.Write(n + " ");
  if (n >= 2) ShowIntNum(n - 1);
}
ShowIntNum(5);
*/

// Task 2.Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

/*
int SumFunction(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    return SumFunction(m, n - 1) + n;
}
Console.Write(SumFunction(1, 3));
*/

// Task 3.Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

/*
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int functionAkkerman = Ack(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
*/
