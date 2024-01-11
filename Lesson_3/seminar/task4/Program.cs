Console.Write("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = new int[3];

for (int i = 0; i < array.Length; i++)
{
    array[i] = number % 10;
    number /= 10;
}

Console.WriteLine("");
Console.Write($"Знаки данного числа: [{string.Join(' ', array)}]");