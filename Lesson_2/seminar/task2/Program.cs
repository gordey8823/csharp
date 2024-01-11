Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int exponent = number % 10;
int baseNumber = number / 10 % 10;
int result = 1;

for (int i = 0; i < exponent; i++)
{
    result *= baseNumber;
}

Console.WriteLine(result);