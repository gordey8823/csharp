Console.Write("Введите натуральное число N: ");

string number = Console.ReadLine();

int numberLength = number.Length;

if (Convert.ToInt32(number) < 10)
{
    Console.Write(number);
}
else
{
    for (int i = 0; i < numberLength; i++)
    {
        Console.Write(number[i]);
        Console.Write(", ");
    }
    Console.Write(number[numberLength - 1]);
}
