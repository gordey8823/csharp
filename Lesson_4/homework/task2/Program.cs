int[] CreateNumbers(int number)
{
    int[] array = new int [number];
    for (int i = 0; i < number; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int GetCountEvenNumbers(int[] array)
{
    int count = 0;
    foreach (int a in array)
    {
        if (a % 2 == 0) count++;
    }
    return count;
}

int[] numbers = CreateNumbers(10);

Console.WriteLine($" В списке :[{string.Join(", ", numbers)}] четных чисел- {GetCountEvenNumbers(numbers)}");