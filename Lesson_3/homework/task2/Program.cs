int[] array = { 10, 21, 14, 93, 23, 15, 17, 43, 97, 12 }; //3
int count = 0;

foreach (int i in array)
{
    if (i % 2 == 0)
    {
        count += 1;
    }
}

Console.Write($"Количество в массиве целых чётных чисел {count}");