Console.Write("Введите координату по оси X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату по оси Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.Write($"Точка {x}:{y} находится в первой четверти");
    return;
}
else if (x < 0 && y > 0)
{
    Console.Write($"Точка {x}:{y} находится во второй четверти");
    return;
}
else if (x < 0 && y < 0)
{
    Console.Write($"Точка {x}:{y} находится в третьей четверти");
    return;
}
else if (x > 0 && y < 0)
{
    Console.Write($"Точка {x}:{y} находится в четвертой четверти");
    return;
}

