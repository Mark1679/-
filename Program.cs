
//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
//string rec(int n)
//{
//   if (n == 0)
//        return "";
//   return rec(n - 1) + $"{n}";
//}
//                              rec(0)
//                        rec(0) + '1'
//                  rec(1) + '2'
//            rec(2) + '3'
//      rec(3) + '4'
//rec(4) + '5'
//''
//1
//2
//3
//4
//5


//Задчача 2 66
//Console.Write("M = ");
//int M = int.Parse(Console.ReadLine());
//Console.Write("N = ");
//int N = int.Parse(Console.ReadLine());
//Console.WriteLine($"Result, S = {SumNumbers(M, N)}");
//Console.ReadLine();
// 
//static int SumNumbers(int M, int N)
//{
//    if (M == 0) return (N * (N + 1)) / 2;            // Если M равно нулю
//    else if (N == 0) return (M * (M + 1)) / 2;       // Если N равно нулю
//    else if (M == N) return M;                       // Если M=N
//    else if (M < N) return N + SumNumbers(M, N - 1); // Если M<N
//    else return N + SumNumbers(M, N + 1);            // Если M>N
//}

static uint Akk(uint n, uint m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Akk(n - 1, 1);
    else
        return Akk(n - 1, Akk(n, m - 1));
}
 
Console.WriteLine(Akk(1, 2)); // 4
Console.WriteLine(Akk(0, 0)); // 1
Console.WriteLine(Akk(4, 5)); // Stack Overflow !
 
Console.ReadKey();