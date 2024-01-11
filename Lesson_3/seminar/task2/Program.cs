int[] array = { -3, -4, -5, -2, -7, 7, 3, 8, 1, 9 };

for (int i = 0; i < array.Length; i++)
{
    array[i] *= -1;
}

Console.Write(string.Join(" ", array));
