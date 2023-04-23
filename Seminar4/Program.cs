// int QuantityOfDigits(int number)
// {
//   int quantity=0;
//   if(number == 0) quantity = 1;
//   while(number !=0);
//   {
//     number = number/10;   //number/=10
//     quantity++;
//   }
//   return quantity;
// }
// Console.Write("Input a Number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int result =QuantityOfDigits(num);
// Console.WriteLine($"Tour number contains {result} sigits");

//Task 1.Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// int Sum(int n)
// {
//     int summa = 0;
//     int count = 0;
//     while(count <=n)
//     {
//         summa = summa + count;
//         count ++;
//     }
//     return summa;
// }
// Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int res = Sum(num);
// Console.WriteLine($"Введенное число {num}, Сумма {res}");

//Task 2.Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// int Factorial(int n)
// {
//     int comp = 1;
//     int count = 1;
//     while(count <=n)
//     {
//         comp = comp * count;
//         count ++;
//     }
//     return comp;
// }
// Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine()); 
// int result = Factorial(num);
// Console.WriteLine($"Введенное число {num}, Произведение - {result}");