Console.Write("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = new int[3];
int index = 0;

while (number > 0)
{
    array[index] = number % 10;
    index +=1;
    number /= 10;
}
Console.WriteLine("");
Console.Write($"Знаки данного числа: ");

foreach (int i in array)
{
    Console.Write($"{i} ");
}