Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = number / 100 * 10 + number % 10;

Console.WriteLine(result);