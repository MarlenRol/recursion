Console.Write($"Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

void REK(int M, int N)
{
    if (N < 0 || M < 0)
    {
        Console.Write($"Необходимо вести натуральные числа N и M");
        return;
    }
    if (N == M)
    {
        return;
    }
    if (M < N)
    {     
        Console.Write(M);
        REK(M+1, N);
    }

}
REK(M, N);