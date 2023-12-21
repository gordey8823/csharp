Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int lastNum = num % 10;
int firstNum = 0;

while (num != 0)
{
    firstNum = num % 10;
    num /= 10;
}

Console.WriteLine($"Сумма первого и последнего знаков числа равна: {firstNum + lastNum}.");
