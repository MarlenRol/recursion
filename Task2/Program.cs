Console.Write($"Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int functionAkkerman = Ack(M, N);

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