int[] ReverseArray(int[] array)
{
    int secondPerem = 0;
    for (int i = 0, j = array.Length - 1; i < array.Length / 2; i++, j--)
    {
        secondPerem = array[i];
        array[i] = array[j];
        array[j] = secondPerem;
    }
    return array;
}

int[] arrayN = { 1, 2, 3, 4, 5, 6 };

string str1 = string.Join(", ", arrayN);
string str2 = string.Join(", ", ReverseArray(arrayN));

Console.Write($"Массив [{str1}] перевернем и получим [{str2}]");