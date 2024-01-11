int[] array = { 10, 21, 14, 93, 23, 15, 17, 43, 97, 12 }; // 4
int count = 0;

foreach (int i in array)
{
    if (20 <= i && i <= 90)
    {
        count += 1;
    }
}

Console.Write($"В промежутке от 20 до 90 целых чисел {count}");