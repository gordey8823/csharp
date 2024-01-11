int[] array = { 1, 3, 4, 19, 3 };
Console.Write("Введи искомое число: ");
int searchNumber = Convert.ToInt32(Console.ReadLine());
bool available = false;



foreach (int elem in array)
{
    if (elem == searchNumber)
    {
        available = true;
        break;
    }

}

if (available)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}