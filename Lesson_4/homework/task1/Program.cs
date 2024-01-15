bool CheckDivisionSumNumbersByTwo(string num)
{
    int number;
    // 
    if (int.TryParse(num, out number))
    {
        int myNum = Convert.ToInt32(num);
        int sum = 0;
        while (myNum > 0)
        {
            sum += myNum % 10;
            myNum /= 10;
        }
        return sum % 2 == 0;
    }
    else
    {
        return false;
    }
    
}

while (true)
{
    Console.Write("Введите число, или 'q' для завершения: ");
    string input = Console.ReadLine();
    if (input == "q" || CheckDivisionSumNumbersByTwo(input)) break;
}

