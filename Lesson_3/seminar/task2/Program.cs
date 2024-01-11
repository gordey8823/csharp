int[] array = { -3, -4, -5, -2, -7, 7, 3, 8, 1, 9 };

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        array[i] = -array[i];
    }
    else 
    {
        array[i] = array[i] * -1;
    }
}

foreach (int l in array)
{
    Console.Write($"{l} ");
}

