Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int firstNumber = number / 10 % 10;
int secondNumber = number % 10;

if (firstNumber > secondNumber)
{
    Console.Write($"У введенного числа `{number}` первый знак `{firstNumber}` больше второго `{secondNumber}`");
}
else if(secondNumber > firstNumber)
{
    Console.Write($"У введенного числа `{number}` первый знак `{firstNumber}` меньше второго `{secondNumber}`");
}
else if (secondNumber == firstNumber)
{
    Console.Write($"У введенного числа `{number}` знаки равны `{secondNumber}`");
}