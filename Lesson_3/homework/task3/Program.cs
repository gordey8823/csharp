double[] array = { 2.2, 0.4, 9.11, 7.2, 78.98 };

double min = array[0];
double max = array[0];

foreach (double i in array)
{
    if (i > max)
    {
        max = i;
    }
    if (i < min)
    {
        min = i;
    }
}

Console.Write($"Разница между минимальным {min} и максимальным {max} числом равна {max - min}");