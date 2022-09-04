// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

int M = InputNumbers("Введите число M: ");
int N = InputNumbers("Введите число N: ");
int tempory = M;

if (M > N) 
{
  M = N; 
  N = tempory;
}

PrintSumm(M, N, tempory = 0);

void PrintSumm(int M, int N, int summa)
{
  summa = summa + N;
  if (N <= M)
  {
    Console.Write($"Сумма элементов равна {summa} ");
    return;
  }
  PrintSumm(M, N - 1, summa);
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}