Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());

int i = -n;

while (i <= n)
{
    Console.Write(i);
    Console.Write(' ');
    i += 1;
}
