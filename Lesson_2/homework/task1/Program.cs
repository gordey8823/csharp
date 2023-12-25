Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 7 ==0 && number % 23 == 0)
{
    Console.Write($"Введенное число {number} делиться нацело на 7 и на 23");
}
else
{
    Console.Write($"Введенное число {number} не делиться нацело на 7 и на 23");
}