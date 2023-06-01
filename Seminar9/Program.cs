// void ShowNum(int num)
// {
//   if (num > 1) ShowNum(num - 1);
//   Console.Write(num + " ");
// }

// ShowNum(5);

/*
int SumOfDigits(int num)
{
  if (num != 0) return SumOfDigits(num / 10) + num % 10;
  return 0;
}

Console.WriteLine(SumOfDigits(1234));
*/

// f(1234)->f(123) + 4
// f(123)->f(12) + 3
// f(12)->f(1) + 2
// f(1)->f(0) + 1
// f(0)-> 0
// f(1)-> 0 + 1 = 1
// f(12)-> 1 + 2 = 3
// f(123)-> 3 + 3 = 6
// f(1234)-> 6 + 4 = 10

//Task 1.

/*
void ShowIntNum(int m, int n)
{
  if (n > m)
  {
    ShowIntNum(m, n - 1);
    Console.Write(n + " ");
  }
  if (m > n)
  {
    ShowIntNum(m, n + 1);
    Console.Write(n + " ");
  }
  if (m == n)
  {
    Console.Write(m + " ");
  }
}

ShowIntNum(1, 5);
*/

//Task 2.

/*
int MultipLyNum(int a, int b)
{
  if (b!= 0) return MultipLyNum(a, b - 1) * a;
  return 1;
}

Console.Write(MultipLyNum(2, 6));
*/
