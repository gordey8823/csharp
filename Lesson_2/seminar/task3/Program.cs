Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int remainder = number1 % number2;

if (remainder == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine ($"нет, {remainder}");
}