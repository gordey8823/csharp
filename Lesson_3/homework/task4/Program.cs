Console.Write("Введите натуральное число от 1 до 100000: ");
int number = Convert.ToInt32(Console.ReadLine());

int numberCopy = number;
int count = 0;
while (numberCopy > 0)
{
    count += 1;
    numberCopy /= 10;
}

int[] array = new int[count];

for (int i = array.Length; i > 0; i--)
{
    array[i - 1] = number % 10;
    number /= 10;
}

Console.Write("Знаки числа: ");
foreach (int n in array)
{
    Console.Write($"{n} ");
}