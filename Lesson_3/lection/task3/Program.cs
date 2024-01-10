int[] arr = { 2, 5, 4, 7, 8, 35, 1, 3, 8, 5 };
int i = 0;
int max = arr[0];

foreach (int n in arr)
{
    if (n > max)
    {
        max = n;
    }
    i += 1;
}

Console.WriteLine($"Максимальное число: {max}");