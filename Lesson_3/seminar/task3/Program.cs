int[] array = { 2, 3, 1, 7, 5, 6, 3 };
int[] arrayRezult = new int[array.Length / 2];

for (int i = 0, j = array.Length - 1; i < array.Length / 2; i++, j--)
{
    arrayRezult[i] = array[i] * array[j];
}

Console.Write(string.Join(" ", arrayRezult));