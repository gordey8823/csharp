int A(int n, int m)
{
    if (n == 0) return m + 1;
    if (m == 0) return A(n - 1, 1);
    return A(n - 1, A(n, m - 1));
}

int m = 2;
int n = 3;
Console.Write($"A({m},{n}) = {A(n,m)}");