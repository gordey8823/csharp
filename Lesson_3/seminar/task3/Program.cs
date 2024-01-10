int[] array = { 2, 3, 1, 7, 5, 6, 3 };
int[] arrayRezult = new int[array.Length / 2];
int back = array.Length - 1;



for (int i = 0; i < array.Length / 2; i++)
{
    arrayRezult[i] = array[i] * array[back - i];
}

foreach (int n in arrayRezult)
{
    Console.Write(n + " ");
}