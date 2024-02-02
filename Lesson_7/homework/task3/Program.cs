string getReversedDigits(int[] array)
{
    string rezult = $"{array[array.Length - 1]}";
    if (array.Length == 1)
    {
        return rezult;
    }
    else
    {
        return $"{rezult}, {getReversedDigits(array.SkipLast(1).ToArray())}";
    }
}


int[] arrayDigits = { 1, 2, 3, 4, 5 };

Console.Write($"[ {getReversedDigits(arrayDigits)} ]");